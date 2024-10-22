﻿using Mybot.ChromeDevTools.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using WebSocket4Net;

namespace Mybot.ChromeDevTools
{
    public class ChromeSession : IChromeSession
    {
        private readonly string _endpoint;
        private readonly ConcurrentDictionary<string, ConcurrentBag<Action<object>>> _handlers = new ConcurrentDictionary<string, ConcurrentBag<Action<object>>>();
        private ICommandFactory _commandFactory;
        private IEventFactory _eventFactory;
        private ManualResetEvent _openEvent = new ManualResetEvent(false);
        private ManualResetEvent _publishEvent = new ManualResetEvent(false);
        private ConcurrentDictionary<long, ManualResetEventSlim> _requestWaitHandles = new ConcurrentDictionary<long, ManualResetEventSlim>();
        private ICommandResponseFactory _responseFactory;
        private ConcurrentDictionary<long, ICommandResponse> _responses = new ConcurrentDictionary<long, ICommandResponse>();
        private WebSocket _webSocket;
        private static object _Lock = new object();

        private ManualResetEvent _soketStatusEvent = new ManualResetEvent(false);
        public Exception socketExeption;
        internal readonly Action<string, Exception> logger;

        public string ProxyUser { get; set; }
        public string ProxyPass { get; set; }
        public Process Process { get; set; }
        public string MainSessionId { get; set; }
        public string BrowserEndPoint { get; set; }

        public ChromeSession(string endpoint, ICommandFactory commandFactory, ICommandResponseFactory responseFactory, 
            IEventFactory eventFactory, Action<string, Exception> logger)
        {
            _endpoint = endpoint;
            _commandFactory = commandFactory;
            _responseFactory = responseFactory;
            _eventFactory = eventFactory;
            this.logger = logger;
        }

        public void Dispose()
        {
            if (null == _webSocket) return;
            if (_webSocket.State == WebSocketState.Open)
            {
                _webSocket.Close();
            }
            _webSocket.Dispose();
        }

        private void EnsureInit()
        {
            if (null == _webSocket)
            {
                lock (_Lock)
                {
                    if (null == _webSocket)
                    {
                        Init().Wait();
                    }
                }
            }
        }

        private Task Init()
        {
            _openEvent.Reset();

            _webSocket = new WebSocket(_endpoint);
            _webSocket.EnableAutoSendPing = false;
            _webSocket.Opened += WebSocket_Opened;
            _webSocket.MessageReceived += WebSocket_MessageReceived;
            _webSocket.Error += WebSocket_Error;
            _webSocket.Closed += WebSocket_Closed;
            _webSocket.DataReceived += WebSocket_DataReceived;

            _webSocket.Open();
            return Task.Run(() =>
            {
                _openEvent.WaitOne();
            });
        }

        private void WebSocket_Opened(object sender, EventArgs e)
        {
            _openEvent.Set();
        }

        private void WebSocket_Closed(object sender, EventArgs e)
        {
        }

        public Task<ICommandResponse> SendAsync<T>(CancellationToken cancellationToken)
        {
            var command = _commandFactory.Create<T>();
            return SendCommand(command, cancellationToken);
        }

        public Task<CommandResponse<T>> SendAsync<T>(ICommand<T> parameter, CancellationToken cancellationToken)
        {
            var command = _commandFactory.Create(parameter);
            var task = SendCommand(command, cancellationToken);
            return CastTaskResult<ICommandResponse, CommandResponse<T>>(task);
        }

        private Task<TDerived> CastTaskResult<TBase, TDerived>(Task<TBase> task) where TDerived: TBase
        {
            var tcs = new TaskCompletionSource<TDerived>();
            task.ContinueWith(t => tcs.SetResult((TDerived)t.Result),
                TaskContinuationOptions.OnlyOnRanToCompletion);
            task.ContinueWith(t => tcs.SetException(t.Exception.InnerExceptions),
                TaskContinuationOptions.OnlyOnFaulted);
            task.ContinueWith(t => tcs.SetCanceled(),
                TaskContinuationOptions.OnlyOnCanceled);
            return tcs.Task;
        }

        public void Subscribe<T>(Action<T> handler) where T : class
        {
            var handlerType = typeof(T);
            var handlerForBag = new Action<object>(obj => handler((T)obj));
            _handlers.AddOrUpdate(handlerType.FullName,
                (m) => new ConcurrentBag<Action<object>>(new [] { handlerForBag }),
                (m, currentBag) =>
                {
                    currentBag.Add(handlerForBag);
                    return currentBag;
                });
        }

        private void HandleEvent(IEvent evnt)
        {
            if (null == evnt
                || null == evnt)
            {
                return;
            }
            var type = evnt.GetType().GetGenericArguments().FirstOrDefault();
            if (null == type)
            {
                return;
            }
            var handlerKey = type.FullName;
            ConcurrentBag<Action<object>> handlers = null;
            if (_handlers.TryGetValue(handlerKey, out handlers))
            {
                var localHandlers = handlers.ToArray();
                foreach (var handler in localHandlers)
                {
                    ExecuteHandler(handler, evnt);
                }
            }
        }

        private void ExecuteHandler(Action<object> handler, dynamic evnt)
        {
            if (evnt.GetType().GetGenericTypeDefinition() == typeof(Event<>))
            {
                handler(evnt.Params);
            } else
            {
                handler(evnt);
            }
        }

        private void HandleResponse(ICommandResponse response)
        {
            if (null == response) return;
            ManualResetEventSlim requestMre;
            if (_requestWaitHandles.TryGetValue(response.Id, out requestMre))
            {
                _responses.AddOrUpdate(response.Id, id => response, (key, value) => response);
                requestMre.Set();
            }
            else
            {
                // in the case of an error, we don't always get the request Id back :(
                // if there is only one pending requests, we know what to do ... otherwise
                if (1 == _requestWaitHandles.Count)
                {
                    var requestId = _requestWaitHandles.Keys.First();
                    _requestWaitHandles.TryGetValue(requestId, out requestMre);
                    _responses.AddOrUpdate(requestId, id => response, (key, value) => response);
                    requestMre.Set();
                }
            }
        }

        private Task<ICommandResponse> SendCommand(Command command, CancellationToken cancellationToken)
        {
            if (MainSessionId != null) command.SessionId = MainSessionId;

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new MessageContractResolver(),
                NullValueHandling = NullValueHandling.Ignore,
            };
            var requestString = JsonConvert.SerializeObject(command, settings);
            var requestResetEvent = new ManualResetEventSlim(false);
            _requestWaitHandles.AddOrUpdate(command.Id, requestResetEvent, (id, r) => requestResetEvent);
            return Task.Run(() =>
            {
                EnsureInit();
                _webSocket.Send(requestString);
                requestResetEvent.Wait(cancellationToken);
                ICommandResponse response = null;
                _responses.TryRemove(command.Id, out response);
                _requestWaitHandles.TryRemove(command.Id, out requestResetEvent);
                return response;
            });
        }

        private bool TryGetCommandResponse(byte[] data, out ICommandResponse response)
        {
            response = _responseFactory.Create(data);
            return null != response;
        }

        private bool TryGetCommandResponse(string message, out ICommandResponse response)
        {
            response = _responseFactory.Create(message);
            logger(message, null);
            return null != response;
        }

        private bool TryGetEvent(byte[] data, out IEvent evnt)
        {
            evnt = _eventFactory.Create(data);
            return null != evnt;
        }

        private bool TryGetEvent(string message, out IEvent evnt)
        {
            evnt = _eventFactory.Create(message);
            //logger(message, null);
            return null != evnt;
        }

        private void WebSocket_DataReceived(object sender, WebSocket4Net.DataReceivedEventArgs e)
        {
            ICommandResponse response;
            if (TryGetCommandResponse(e.Data, out response))
            {
                HandleResponse(response);
                return;
            }
            IEvent evnt;
            if (TryGetEvent(e.Data, out evnt))
            {
                HandleEvent(evnt);
                return;
            }
            throw new Exception("Don't know what to do with response: " + e.Data);
        }

        private void WebSocket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            _soketStatusEvent.Set();
            socketExeption = e.Exception;
            HandleError(e.Exception);
        }

        private void HandleError(Exception ex)
        {
            while (_requestWaitHandles.Count > 0)
            {
                var reqId = _requestWaitHandles.Keys.First(); ;
                var requestWaitHandle = _requestWaitHandles.Where(r => r.Key == reqId).First().Value;

                ManualResetEventSlim mrs = new ManualResetEventSlim();

                JObject jo = new JObject(new JProperty("error",
                    new JObject(
                        new JProperty("Message", ex.Message), new JProperty("Code", "1"))));

                ICommandResponse response = _responseFactory.Create(jo.ToString());

                _responses.AddOrUpdate(reqId, id => response, (key, value) => response);
                requestWaitHandle.Set();

                _requestWaitHandles.TryRemove(reqId, out mrs);
            }
        }

        private void WebSocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            ICommandResponse response;
            if (TryGetCommandResponse(e.Message, out response))
            {
                HandleResponse(response);
                return;
            }
            IEvent evnt;
            if (TryGetEvent(e.Message, out evnt))
            {
                HandleEvent(evnt);
                return;
            }
            //throw new Exception("Don't know what to do with response: " + e.Message);
        }

        public void ProxyAuthenticate(string proxyUser, string proxyPass)
        {
            ProxyUser = proxyUser;
            ProxyPass = proxyPass;
        }

        public string GetEndPoint()
        {
            return _endpoint;
        }
    }
}
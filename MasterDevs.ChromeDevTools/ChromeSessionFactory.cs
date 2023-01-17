#if !NETSTANDARD1_5
using System;
using System.Diagnostics;

namespace Mybot.ChromeDevTools
{
    public class ChromeSessionFactory : IChromeSessionFactory
    {
        public IChromeSession Create(ChromeSessionInfo sessionInfo, Action<string, Exception> logger)
        {
            return Create(sessionInfo.WebSocketDebuggerUrl, logger);
        }

        public IChromeSession Create(string endpointUrl, Action<string, Exception> logger)
        {
            // Sometimes binding to localhost might resolve wrong AddressFamily, force IPv4
            endpointUrl = endpointUrl.Replace("ws://localhost", "ws://127.0.0.1");
            var methodTypeMap = new MethodTypeMap();
            var commandFactory = new CommandFactory();
            var responseFactory = new CommandResponseFactory(methodTypeMap, commandFactory);
            var eventFactory = new EventFactory(methodTypeMap);
            var session = new ChromeSession(endpointUrl, commandFactory, responseFactory, eventFactory, logger);
            return session;
        }

        public IChromeSession Create(string endpointUrl, Process process, Action<string, Exception> logger)
        {
            // Sometimes binding to localhost might resolve wrong AddressFamily, force IPv4
            endpointUrl = endpointUrl.Replace("ws://localhost", "ws://127.0.0.1");
            var methodTypeMap = new MethodTypeMap();
            var commandFactory = new CommandFactory();
            var responseFactory = new CommandResponseFactory(methodTypeMap, commandFactory);
            var eventFactory = new EventFactory(methodTypeMap);
            var session = new ChromeSession(endpointUrl, commandFactory, responseFactory, eventFactory, logger);
            session.Process = process;
            return session;
        }
    }
}
#endif

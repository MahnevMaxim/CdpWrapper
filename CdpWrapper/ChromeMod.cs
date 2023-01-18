using Mybot.ChromeDevTools.Protocol.Chrome.Network;
using Mybot.ChromeDevTools.Protocol.Chrome.Page;
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace CdpWrapper
{
    public class ChromeMod
    {
        private string currentUrl;

        public string CurrentUrl
        {
            get => currentUrl;
            private set
            {
                if (currentUrl != value)
                {
                    currentUrl = value;
                }
            }
        }

        private static readonly int MinDebugPort = 9222;
        private static readonly int MaxDebugPort = 59999;

        public IChromeProcess ChromeProcess { get; set; }
        public IChromeSession ChromeSession { get; set; }

        private int port;
        internal readonly Action<string, Exception> logger;
        private readonly bool isVisible;
        private readonly string profilePath;
        private readonly string exeFilePath;

        public ChromeMod(Action<string, Exception> logger, bool isVisible, string profilePath, string exeFilePath, List<string> args = null, string profileArgs = null)
        {
            this.logger = logger;
            this.isVisible = isVisible;
            this.profilePath = profilePath;
            this.exeFilePath = exeFilePath;
            Task task = Task.Run(() => CreateChromeSession(args, profileArgs).ConfigureAwait(false).GetAwaiter().GetResult());
            task.Wait();
        }

        #region Init

        /// <summary>
        /// Это версия для передачи аргументов командной строки
        /// </summary>
        public async Task CreateChromeSession(List<string> args = null, string profileArgs = null)
        {
            if (args != null)
            {
                foreach (string arg in args)
                {
                    logger(arg, null);
                }
            }

            ChromeProcessFactory chromeProcessFactory = new ChromeProcessFactory(exeFilePath);
            port = GetFreeLocalPort();
            logger($"FreeLocalPort: {port}", null);
            ChromeProcess = chromeProcessFactory.CreateNew(port, !isVisible, null, profilePath, null, args, profileArgs);
            string rdb = ChromeProcess?.RemoteDebuggingUri?.AbsoluteUri;
            if (rdb != null)
            {
                logger($"RemoteDebuggingUri: {rdb}", null);
            }
            else
            {
                logger("RemoteDebuggingUri: null", null);
            }

            ChromeSessionInfo[] sessionInfoArray = null;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    sessionInfoArray = await ChromeProcess.GetSessionInfo();
                    logger($"sessionInfoArray array count: {sessionInfoArray.Length}", null);
                    break;
                }
                catch (Exception ex)
                {
                    logger(ex.StackTrace, null);
                }
                await Task.Delay(1000);
            }

            ChromeSessionInfo sessionInfo = null;
            // TODO: sessionInfoArray часто NULL
            foreach (ChromeSessionInfo si in sessionInfoArray)
            {
                if (si.Type == "page")
                {
                    sessionInfo = si;
                    break;
                }
            }

            if (sessionInfo == null)
            {
                throw new Exception("Не удалось получить информацию о сессии cdt");
            }

            logger($"sessionInfo: {sessionInfo.Type} {sessionInfo.Url}", null);

            ChromeSessionFactory chromeSessionFactory = new ChromeSessionFactory();
            ChromeSession = chromeSessionFactory.Create(sessionInfo.WebSocketDebuggerUrl, logger);

            ChromeSession.Subscribe<FrameNavigatedEvent>(frameNavigatedEvent =>
            {
                FrameNavigatedEventHandler(frameNavigatedEvent);
            });

            ChromeSession.Subscribe<LoadingFinishedEvent>(loadingFinishedEvent =>
            {
                LoadingFinishedEventHandler(loadingFinishedEvent);
            });

            logger($"sessionInfo.WebSocketDebuggerUrl: {sessionInfo.WebSocketDebuggerUrl}", null);

            ChromeSession.BrowserEndPoint = await ChromeProcess.GetBrowserSessionInfo();
        }

        public async Task<ChromeSessionInfo[]> GetSessionInfo(int port)
        {
            try
            {
                HttpClient http = new HttpClient()
                {
                    BaseAddress = new Uri($"http://localhost:{port}")
                };

                string json = await http.GetStringAsync("/json");
                return JsonConvert.DeserializeObject<ChromeSessionInfo[]>(json);
            }
            catch (Exception ex)
            {
                logger(ex.Message, ex);
                return null;
            }
        }

        public int GetFreeLocalPort()
        {
            try
            {
                ProcessStartInfo psiOpt = new ProcessStartInfo("cmd.exe", "/C netstat -a -n -o")
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                // запускаем процесс
                Process procCommand = Process.Start(psiOpt);
                // получаем ответ запущенного процесса
                StreamReader srIncoming = procCommand.StandardOutput;
                // выводим результат
                string[] ss = srIncoming.ReadToEnd().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                StringCollection procStr = new StringCollection();
                procCommand.WaitForExit();

                for (int i = MinDebugPort; i < MaxDebugPort; i++)
                {
                    bool portIsBusy = false;
                    string portSignature = $":{i}";
                    foreach (string s in ss)
                    {
                        if (s.Contains(portSignature))
                        {
                            portIsBusy = true;
                            break;
                        }
                    }
                    if (portIsBusy)
                    {
                        continue;
                    }
                    else
                    {
                        return i;
                    }
                }
            }
            catch (Exception ex)
            {
                logger(ex.Message, ex);
            }

            return 0;
        }

#pragma warning disable IDE0060 // Remove unused parameter
        private async void LoadingFinishedEventHandler(LoadingFinishedEvent loadingFinishedEvent)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            try
            {
                CurrentUrl = await GetCurrentUrl();
                logger($"CurrentUrl: {CurrentUrl}", null);
            }
            catch (Exception ex)
            {
                logger(ex.Message, ex);
            }
        }

        private void FrameNavigatedEventHandler(FrameNavigatedEvent frameNavigatedEvent)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(frameNavigatedEvent.Frame.ParentId))
                {
                    CurrentUrl = frameNavigatedEvent.Frame.Url;
                    logger($"CurrentUrl: {CurrentUrl}", null);
                }
            }
            catch (Exception ex)
            {
                logger(ex.Message, ex);
            }
        }

        public async Task<string> GetCurrentUrl()
        {
            string url = null;
            try
            {
                ICommandResponse qs = await ChromeSession.SendAsync<GetFrameTreeCommand>();
                ICommandResponse qs2 = ChromeSession.SendAsync<GetNavigationHistoryCommand>().Result;

                ICommandResponse cr = ChromeSession.SendAsync<GetNavigationHistoryCommand>().Result;
                if (cr == null)
                {
                    return null;
                }

                long index = ((CommandResponse<GetNavigationHistoryCommandResponse>)cr).Result.CurrentIndex;
                url = ((CommandResponse<GetNavigationHistoryCommandResponse>)cr).Result.Entries[index].Url;
            }
            catch (Exception ex)
            {
                logger(ex.Message, ex);
            }
            return url;
        }

        #endregion

        //public async Task<long?> IsElementExist(string cssSelector)
        //{
        //    try
        //    {
        //        long? docNodeId = await GetDocNodeID();
        //        if (docNodeId == null)
        //        {
        //            return null;
        //        }

        //        CommandResponse<QuerySelectorCommandResponse> qs = await chromeSession.SendAsync(new QuerySelectorCommand
        //        {
        //            NodeId = (long)docNodeId,
        //            Selector = cssSelector
        //        });
        //        return qs.Result.NodeId;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        //public async Task<long?> IsElementWithTextExist(string cssSelector, string text)
        //{
        //    try
        //    {
        //        long? docNodeId = await GetDocNodeID();
        //        if (docNodeId == null)
        //        {
        //            return null;
        //        }

        //        CommandResponse<QuerySelectorCommandResponse> qs = await chromeSession.SendAsync(new QuerySelectorCommand
        //        {
        //            NodeId = (long)docNodeId,
        //            Selector = cssSelector
        //        });
        //        long nodeId = qs.Result.NodeId;
        //        CommandResponse<GetOuterHTMLCommandResponse> getHTML = await chromeSession.SendAsync(new GetOuterHTMLCommand { NodeId = nodeId });
        //        string outer = getHTML.Result.OuterHTML;
        //        return outer.Contains(text) ? nodeId : null;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        //public async Task<string> GetText(string cssSelector)
        //{
        //    try
        //    {
        //        long? docNodeId = await GetDocNodeID();
        //        if (docNodeId == null)
        //        {
        //            return null;
        //        }

        //        CommandResponse<QuerySelectorCommandResponse> qs = await chromeSession.SendAsync(new QuerySelectorCommand
        //        {
        //            NodeId = (long)docNodeId,
        //            Selector = cssSelector
        //        });
        //        long nodeId = qs.Result.NodeId;

        //        return (await chromeSession.SendAsync(new GetOuterHTMLCommand { NodeId = nodeId })).Result.OuterHTML;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        //public async Task<Cookie[]> GetCookies()
        //{
        //    Cookie[] cookies = null;
        //    try
        //    {
        //        cookies = (await chromeSession.SendAsync(new GetAllCookiesCommand())).Result.Cookies;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return cookies;
        //}

        //public async Task<CallResult> SetCookies(StringCollection netscapeCookiesColl)
        //{
        //    CallResult cr = new();
        //    string currentString = "";
        //    try
        //    {
        //        foreach (string str in netscapeCookiesColl)
        //        {
        //            currentString = str;
        //            string[] ss = str.Split('\t');
        //            await SetCookie(ss[0], Convert.ToBoolean(ss[1]), ss[2], Convert.ToBoolean(ss[3]), double.Parse(ss[4]), ss[5], ss[6]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger(ex.Message, ex);
        //        cr.Error = new Error($"Исключение при попытке установить куки в формате Netscape из строки: {currentString}");
        //    }
        //    return cr;
        //}

        //internal async Task<CallResult> SetCookies(JArray ja)
        //{
        //    CallResult cr = new();
        //    try
        //    {
        //        foreach (JObject jo in ja.Cast<JObject>())
        //        {
        //            await SetCookie(jo["domain"].ToString(), Convert.ToBoolean(jo["httpOnly"].ToString()), jo["path"].ToString(),
        //                Convert.ToBoolean(jo["secure"].ToString()), double.Parse(jo["expirationDate"].ToString()),
        //                jo["name"].ToString(), jo["value"].ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger(ex.Message, ex);
        //        cr.Error = new Error("Исключение при попытке установить куки в json формате");
        //    }
        //    return cr;
        //}

        //private async Task SetCookie(string domain, bool httpOnly, string path, bool secure, double expires, string name, string value)
        //{
        //    try
        //    {
        //        Log.Write($"{domain} {httpOnly} {path} {secure} {expires} {name} {value}");
        //        CommandResponse<SetCookieCommandResponse> qs = await chromeSession.SendAsync(new SetCookieCommand
        //        {
        //            Domain = domain,
        //            HttpOnly = httpOnly,
        //            Path = path,
        //            Secure = secure,
        //            Expires = expires,
        //            Name = name,
        //            Value = value
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        logger(ex.Message, ex);
        //    }
        //}

        //public async Task<string> GetAttribute(long nodeId, string attrName)
        //{
        //    string attrValue = null;
        //    try
        //    {
        //        CommandResponse<GetAttributesCommandResponse> qs = await chromeSession.SendAsync(new GetAttributesCommand
        //        {
        //            NodeId = nodeId
        //        });
        //        GetAttributesCommandResponse attrArray = qs.Result;
        //        for (int i = 0; i < qs.Result.Attributes.Length; i += 2)
        //        {
        //            if (qs.Result.Attributes[i] == attrName)
        //            {
        //                attrValue = qs.Result.Attributes[i + 1];
        //                break;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    return attrValue;
        //}

        //public async Task RunScript(string script)
        //{
        //    try
        //    {
        //        CommandResponse<AddScriptToEvaluateOnNewDocumentCommandResponse> qs = await chromeSession.SendAsync(new AddScriptToEvaluateOnNewDocumentCommand
        //        {
        //            Source = script
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public async Task<string> GetHtml()
        //{
        //    try
        //    {
        //        long? docNodeId = await GetDocNodeID();
        //        if (docNodeId == null)
        //        {
        //            return null;
        //        }

        //        CommandResponse<GetOuterHTMLCommandResponse> htmlRes = await chromeSession.SendAsync(new GetOuterHTMLCommand
        //        {
        //            NodeId = docNodeId
        //        });
        //        return htmlRes?.Result.OuterHTML;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return null;
        //    }
        //}

        //public async Task ScrollToElement(string cssSelector, int plus = 0)
        //{
        //    try
        //    {
        //        long? nodeId = await GetNodeId(cssSelector);
        //        if (nodeId == null)
        //        {
        //            return;
        //        }

        //        await ScrollToElement((long)nodeId, plus);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public async Task ScrollToElement(long nodeId, int plus = 0)
        //{

        //    try
        //    {
        //        CommandResponse<GetBoxModelCommandResponse> elementBox = await chromeSession.SendAsync(new GetBoxModelCommand
        //        {
        //            NodeId = nodeId
        //        });
        //        int lowPosition = (int)elementBox.Result.Model.Border[5];

        //        CommandResponse<GetLayoutMetricsCommandResponse> metrics = await chromeSession.SendAsync(new GetLayoutMetricsCommand { });
        //        int height = (int)metrics.Result.LayoutViewport.ClientHeight;
        //        int delta = lowPosition - height + plus;

        //        CommandResponse<Chrome.Input.DispatchMouseEventCommandResponse> scroll = await chromeSession.SendAsync(new Chrome.Input.DispatchMouseEventCommand
        //        {
        //            Type = "mouseWheel",
        //            X = 1,
        //            Y = 2,
        //            DeltaX = 0,
        //            DeltaY = delta
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public async Task Scroll(int plus)
        //{
        //    try
        //    {
        //        CommandResponse<Chrome.Input.DispatchMouseEventCommandResponse> scroll = await chromeSession.SendAsync(new Chrome.Input.DispatchMouseEventCommand
        //        {
        //            Type = "mouseWheel",
        //            X = 1,
        //            Y = 2,
        //            DeltaX = 0,
        //            DeltaY = plus
        //        });
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}

        //public async Task<CDPResponse> SetInputImage(string cssSelector, string[] files)
        //{
        //    CDPResponse cdpr = new();
        //    try
        //    {
        //        long? docNodeId = await GetDocNodeID();
        //        if (docNodeId == null)
        //        {
        //            cdpr.ErrorMessage = "document node id is null";
        //            return cdpr;
        //        }
        //        CommandResponse<QuerySelectorCommandResponse> qs = await chromeSession.SendAsync(new QuerySelectorCommand
        //        {
        //            NodeId = (long)docNodeId,
        //            Selector = cssSelector
        //        });
        //        long elementNodeId = qs.Result.NodeId;

        //        CommandResponse<SetFileInputFilesCommandResponse> it = await chromeSession.SendAsync(new SetFileInputFilesCommand
        //        {
        //            NodeId = elementNodeId,
        //            Files = files
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        cdpr.ErrorMessage = ex.Message;
        //    }
        //    return cdpr;
        //}

        //#region Screen

        //public async Task<CDPResponse> GetNodeScreenshot(string cssSelector, string pathForSave)
        //{
        //    CDPResponse cdpr = new();
        //    try
        //    {
        //        long? nodeId = await GetNodeId(cssSelector);
        //        if (nodeId == null)
        //        {
        //            cdpr.ErrorMessage = "document node id is null";
        //            return cdpr;
        //        }
        //        cdpr = await GetNodeScreenshot((long)nodeId, pathForSave);
        //        return cdpr;
        //    }
        //    catch (Exception ex)
        //    {
        //        logger(ex.Message, ex);
        //        cdpr.ErrorMessage = "Не удалось получить скриншот";
        //        return cdpr;
        //    }
        //}

        //public async Task<CDPResponse> GetNodeScreenshot(long nodeId, string pathForSave)
        //{
        //    CDPResponse cdpr = new();
        //    try
        //    {
        //        CommandResponse<GetBoxModelCommandResponse> box = await chromeSession.SendAsync(new GetBoxModelCommand
        //        {
        //            NodeId = nodeId
        //        });
        //        BoxModel boxRes = box.Result.Model;

        //        double leftBegin = boxRes.Border[0];
        //        double leftEnd = boxRes.Border[2];
        //        double topBegin = boxRes.Border[1];
        //        double topEnd = boxRes.Border[5];

        //        CommandResponse<CaptureScreenshotCommandResponse> screenshot = await chromeSession.SendAsync(new CaptureScreenshotCommand { Format = "png" });
        //        byte[] byteArr = Convert.FromBase64String(screenshot.Result.Data);

        //        int leftTopX = Convert.ToInt32(leftBegin);
        //        int leftTopY = Convert.ToInt32(topBegin);
        //        int X = Convert.ToInt32(leftEnd - leftBegin);
        //        int Y = Convert.ToInt32(topEnd - topBegin);

        //        Rectangle rectangle = new(leftTopX, leftTopY, X, Y);

        //        Bitmap bmp;
        //        using (MemoryStream ms = new(byteArr))
        //        {
        //            bmp = new Bitmap(ms);
        //        }
        //        Bitmap bmp2 = bmp.Clone(rectangle, PixelFormat.Format64bppPArgb);
        //        bmp2.Save(pathForSave, ImageFormat.Jpeg);
        //    }
        //    catch (Exception ex)
        //    {
        //        cdpr.ErrorMessage = ex.Message;
        //    }
        //    return cdpr;
        //}

        //public BitmapImage CaptureScreenshot()
        //{
        //    try
        //    {
        //        CommandResponse<CaptureScreenshotCommandResponse> screenshot = chromeSession.SendAsync(new CaptureScreenshotCommand { Format = "png" }).Result;
        //        byte[] byteArr = Convert.FromBase64String(screenshot.Result.Data);

        //        Bitmap bmp;
        //        using (MemoryStream ms = new(byteArr))
        //        {
        //            bmp = new Bitmap(ms);
        //        }
        //        return ConvertBitmap(bmp);
        //    }
        //    catch (Exception ex)
        //    {
        //        logger(ex.Message, ex);
        //        return null;
        //    }
        //}

        //public BitmapImage ConvertBitmap(Bitmap bitmap)
        //{
        //    try
        //    {
        //        MemoryStream ms = new();
        //        bitmap.Save(ms, ImageFormat.Bmp);
        //        BitmapImage image = new();
        //        image.BeginInit();
        //        _ = ms.Seek(0, SeekOrigin.Begin);
        //        image.StreamSource = ms;
        //        image.EndInit();

        //        return image;
        //    }
        //    catch (Exception ex)
        //    {
        //        logger(ex.Message, ex);
        //        return null;
        //    }
        //}

        //#endregion
    }
}

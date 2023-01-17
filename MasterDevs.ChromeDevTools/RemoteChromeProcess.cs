using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Mybot.ChromeDevTools
{
    public class RemoteChromeProcess : IChromeProcess
    {
        private readonly HttpClient http;

        public Uri RemoteDebuggingUri { get; }

        public Process Process { get; set; }

        public string ProfilePath { get; set; }

        public RemoteChromeProcess(string remoteDebuggingUri)
            : this(new Uri(remoteDebuggingUri))
        {

        }

        public RemoteChromeProcess(Uri remoteDebuggingUri)
        {
            RemoteDebuggingUri = remoteDebuggingUri;

            http = new HttpClient
            {
                BaseAddress = RemoteDebuggingUri
            };
        }

        public virtual void Dispose()
        {
            http.Dispose();
        }

        public async Task<ChromeSessionInfo[]> GetSessionInfo()
        {
            string json = await http.GetStringAsync("/json");
            return JsonConvert.DeserializeObject<ChromeSessionInfo[]>(json);
        }

        public async Task<ChromeSessionInfo> StartNewSession()
        {
            string json = await http.GetStringAsync("/json/new");
            return JsonConvert.DeserializeObject<ChromeSessionInfo>(json);
        }

        // TODO: check
        public async Task<string> GetBrowserSessionInfo()
        {
            string json = await http.GetStringAsync("/json/version");
            JObject jo = JObject.Parse(json);
            string end = jo["webSocketDebuggerUrl"].ToString();
            return end;
        }
    }
}
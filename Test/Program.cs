using CdpWrapper;
using CdpWrapper.Extensions;
using Mybot.ChromeDevTools;
using Mybot.ChromeDevTools.Protocol.Chrome.Page;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        private static ChromeMod chromeInstance;
        private static string profilePath;

#pragma warning disable 
        static void Main(string[] args)
#pragma warning restore 
        {
            Start();
        }

        private static void Start()
        {
            string localAppDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ChromeModTests");
            profilePath = Path.Combine(localAppDir, Path.GetRandomFileName());

            chromeInstance = new ChromeMod(Logger, true, profilePath);

            _ = Task.Run(() => chromeInstance.GetChromeSession()).Result;
            CallResult<CommandResponse<NavigateCommandResponse>> res = chromeInstance.Navigate("https://mybot.su");
            Thread.Sleep(5000);
            CallResult res2 = chromeInstance.Click("a[href=\"/Account/Login\"]");
        }

        public static void Logger(string mess, Exception ex)
        {
            Console.WriteLine($"{mess}\n{ex?.Message}");
        }

    }
}

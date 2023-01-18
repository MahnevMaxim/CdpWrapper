using Mybot.ChromeDevTools;
using Mybot.ChromeDevTools.Protocol.Chrome.Page;
using Mybot.ChromeDevTools.Wrapper;
using Mybot.ChromeDevTools.Wrapper.Extensions;
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

            chromeInstance = new ChromeMod(Logger, true, profilePath, null);
            CallResult<CommandResponse<NavigateCommandResponse>> res = chromeInstance.Navigate("https://mybot.su");
            Thread.Sleep(5000);
            CallResult res2 = Task.Run(() => chromeInstance.Click("a[href=\"/Account/Login\"]", 10)).Result;
            //Thread.Sleep(5000);
            CallResult res3 = chromeInstance.InsertText("input[id=\"Login\"]", "Я Макс!!!", 0);
            Thread.Sleep(5000);
            chromeInstance.Close();
        }

        public static void Logger(string mess, Exception ex)
        {
            Console.WriteLine($"{mess}\n{ex?.Message}");
        }
    }
}

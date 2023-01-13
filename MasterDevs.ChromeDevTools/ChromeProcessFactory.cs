using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace MasterDevs.ChromeDevTools
{
    public class ChromeProcessFactory : IChromeProcessFactory
    {
        public IDirectoryCleaner DirectoryCleaner { get; set; }
        public string ChromePath { get; }

        //public ChromeProcessFactory(IDirectoryCleaner directoryCleaner, string chromePath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe")
        //public ChromeProcessFactory(IDirectoryCleaner directoryCleaner, string chromePath = @"chr\chrome.exe")
        public ChromeProcessFactory(IDirectoryCleaner directoryCleaner, string chromePath = @"chr\chrome.exe")
        {
            DirectoryCleaner = directoryCleaner;
            ChromePath = chromePath;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="port"></param>
        /// <param name="headless"></param>
        /// <param name="proxyServer">string ip:port (example: 213.226.76.117:8000)</param>
        /// <returns></returns>
        //public IChromeProcess Create(int port, bool headless, string proxyServer = null, string path = null, string proxyProtocol = null, string startUrl = null)
        public IChromeProcess Create(int port, bool headless, string proxyServer = null, string path = null, string proxyProtocol = null, List<string> args = null, string personaArgs = null)
        {
            if (path == null)
            {
                path = Path.GetRandomFileName();
            }

            DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));
            var remoteDebuggingArg = $"--remote-debugging-port={port}";
            var userDirectoryArg = $"--user-data-dir=\"{directoryInfo.FullName}\"";
            const string headlessArg = "--headless";
            var chromeProcessArgs = new List<string>
            {
                remoteDebuggingArg,
                userDirectoryArg,
                "--bwsi",
                "--no-first-run"
            };

            if (headless)
                chromeProcessArgs.Add(headlessArg);

            if (proxyServer != null)
            {
                if (proxyProtocol == "http")
                {
                    chromeProcessArgs.Add($"--proxy-server=http://{proxyServer}");
                }

                if (proxyProtocol == "socks5")
                {
                    string arg = $"--host-resolver-rules=\"MAP * ~NOTFOUND , EXCLUDE {proxyServer}\"";
                    chromeProcessArgs.Add($"--proxy-server=\"socks5://{proxyServer}\"");
                }
            }

            if (args != null)
                foreach (string arg in args)
                    chromeProcessArgs.Add(arg);

            var processStartInfo = new ProcessStartInfo(ChromePath, string.Join(" ", chromeProcessArgs) + " " + personaArgs);
            var chromeProcess = Process.Start(processStartInfo);

            string remoteDebuggingUrl = "http://localhost:" + port;
            return new LocalChromeProcess(new Uri(remoteDebuggingUrl), () => DirectoryCleaner.Delete(directoryInfo), chromeProcess, path);
        }

        public IChromeProcess CreateNew(int port, bool headless, string proxyServer, string path, string proxyProtocol = null, List<string> args = null, string personaArgs = null)
        {
            DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
            var remoteDebuggingArg = $"--remote-debugging-port={port}";
            var userDirectoryArg = $"--user-data-dir=\"{directoryInfo.FullName}\"";
            const string headlessArg = "--headless";
            //const string sizeArg = "--window-size=950,640";
            var chromeProcessArgs = new List<string>
            {
                remoteDebuggingArg,
                userDirectoryArg,
                //sizeArg,
                "--bwsi",
                "--no-first-run"
            };

            if (headless)
                chromeProcessArgs.Add(headlessArg);

            if (proxyServer != null)
            {
                if (proxyProtocol == "http")
                {
                    chromeProcessArgs.Add($"--proxy-server=http://{proxyServer}");
                }

                if (proxyProtocol == "socks5")
                {
                    string arg = $"--host-resolver-rules=\"MAP * ~NOTFOUND , EXCLUDE {proxyServer}\"";
                    chromeProcessArgs.Add($"--proxy-server=\"socks5://{proxyServer}\"");
                }
            }

            if (args != null)
            {
                foreach (string arg in args)
                {
                    chromeProcessArgs.Add(arg);
                }   
            }
               
            var processStartInfo = new ProcessStartInfo(ChromePath, string.Join(" ", chromeProcessArgs) + " " + personaArgs);
            var chromeProcess = Process.Start(processStartInfo);

            string remoteDebuggingUrl = "http://localhost:" + port;
            return new LocalChromeProcess(new Uri(remoteDebuggingUrl), () => DirectoryCleaner.Delete(directoryInfo), chromeProcess, path);
        }
    }
}
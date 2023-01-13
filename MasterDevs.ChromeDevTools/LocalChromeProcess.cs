using System;
using System.Diagnostics;

namespace MasterDevs.ChromeDevTools
{
    public class LocalChromeProcess : RemoteChromeProcess
    {
        public LocalChromeProcess(Uri remoteDebuggingUri, Action disposeUserDirectory, Process process, string profilePath)
            : base(remoteDebuggingUri)
        {
            DisposeUserDirectory = disposeUserDirectory;
            Process = process;
            this.ProfilePath = profilePath;
        }

        public Action DisposeUserDirectory { get; set; }

        public override void Dispose()
        {
            base.Dispose();

            Process.Kill();
            Process.WaitForExit();
            //            Process.Close();
            DisposeUserDirectory();
        }
    }
}
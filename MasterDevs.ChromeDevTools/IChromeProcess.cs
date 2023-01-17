using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Mybot.ChromeDevTools
{
    public interface IChromeProcess : IDisposable
    {
        Task<ChromeSessionInfo[]> GetSessionInfo();

        Task<ChromeSessionInfo> StartNewSession();

        Uri RemoteDebuggingUri { get; }

        Task<string> GetBrowserSessionInfo();

        Process Process { get; set; }

        string ProfilePath { get; set; }
    }
}
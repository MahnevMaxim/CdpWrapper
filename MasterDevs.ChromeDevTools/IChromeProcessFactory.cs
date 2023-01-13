using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools
{
    public interface IChromeProcessFactory
    {
        IChromeProcess Create(int port, bool headless, string proxyServer = null, string path = null, string proxyProcol = null, List<string> args = null, string personaArgs = null);
    }
}
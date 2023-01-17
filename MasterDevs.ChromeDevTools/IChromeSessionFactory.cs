using System;

namespace Mybot.ChromeDevTools
{
    public interface IChromeSessionFactory
    {
        IChromeSession Create(string endpointUrl, Action<string, Exception> logger);
    }
}
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Mybot.ChromeDevTools
{
    public interface ICommand<T>
    {

    }
    public interface IChromeSession
    {
        Task<CommandResponse<TResponse>> SendAsync<TResponse>(ICommand<TResponse> parameter, CancellationToken cancellationToken);

        Task<ICommandResponse> SendAsync<T>(CancellationToken cancellationToken);

        void Subscribe<T>(Action<T> handler) where T : class;

        string BrowserEndPoint { get; set; }

        string ProxyUser { get; set; }

        string ProxyPass { get; set; }

        void ProxyAuthenticate(string proxyUser, string proxyPass);

        Process Process { get; set; }

        string MainSessionId { get; set; }
    }
}
using System;
using Mybot.ChromeDevTools;
using System.Threading.Tasks;
using Mybot.ChromeDevTools.Protocol.Chrome.Page;
//using static Mybot.ChromeDevTools.Protocol.Chrome.ProtocolName;

namespace CdpWrapper.Extensions
{
    public static class MainChromeModExtensions
    {
        public static async Task<CommandResponse> Close(this ChromeMod chromeMod)
        {
            CommandResponse commandResponse = null;

            try
            {
                commandResponse = await chromeMod.ChromeSession.SendAsync(new Mybot.ChromeDevTools.Protocol.Chrome.Browser.CloseCommand());
            }
            catch (Exception ex)
            {
                chromeMod.logger(ex.Message, ex);
                try
                {
                    chromeMod.ChromeProcess.Process.Kill();
                }
                catch (Exception ex2)
                {
                    chromeMod.logger(ex2.Message, ex2);
                }
            }

            return commandResponse;
        }

        public static CallResult<CommandResponse<NavigateCommandResponse>> Navigate(this ChromeMod chromeMod, string url)
        {
            try
            {
                CommandResponse<NavigateCommandResponse> result = Task.Run(() => chromeMod.ChromeSession.SendAsync(new NavigateCommand { Url = url }))
                    .ConfigureAwait(false).GetAwaiter().GetResult();
                return new CallResult<CommandResponse<NavigateCommandResponse>>() { Data = result };
            }
            catch (Exception ex)
            {
                chromeMod.logger(ex.Message, ex);
                return new CallResult<CommandResponse<NavigateCommandResponse>>() { Error = new Error() };
            }
        }

        public static async Task Reload(this ChromeMod chromeMod)
        {
            try
            {
                ICommandResponse reloadResponse = await chromeMod.ChromeSession.SendAsync<ReloadCommand>();
            }
            catch (Exception ex)
            {
                chromeMod.logger(ex.Message, ex);
            }
        }

        public static async Task GoBack(this ChromeMod chromeMod)
        {
            try
            {
                GetNavigationHistoryCommandResponse historyResponseResult = ((CommandResponse<GetNavigationHistoryCommandResponse>)await chromeMod.ChromeSession.SendAsync<GetNavigationHistoryCommand>()).Result;
                if (historyResponseResult.CurrentIndex > 0)
                {
                    long entryId = historyResponseResult.Entries[historyResponseResult.CurrentIndex - 1].Id;
                    CommandResponse<NavigateToHistoryEntryCommandResponse> qs = await chromeMod.ChromeSession.SendAsync(new NavigateToHistoryEntryCommand
                    {
                        EntryId = long.Parse(entryId.ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                chromeMod.logger(ex.Message, ex);
            }
        }

        public static async Task GoForward(this ChromeMod chromeMod)
        {
            try
            {
                GetNavigationHistoryCommandResponse historyResponseResult = ((CommandResponse<GetNavigationHistoryCommandResponse>)await chromeMod.ChromeSession.SendAsync<GetNavigationHistoryCommand>()).Result;
                long targetIndex = historyResponseResult.CurrentIndex + 1;
                long availableIndex = historyResponseResult.Entries.Length - 1;
                if (targetIndex <= availableIndex)
                {
                    long entryId = historyResponseResult.Entries[historyResponseResult.CurrentIndex + 1].Id;
                    CommandResponse<NavigateToHistoryEntryCommandResponse> qs = await chromeMod.ChromeSession.SendAsync(new NavigateToHistoryEntryCommand
                    {
                        EntryId = long.Parse(entryId.ToString())
                    });
                }
            }
            catch (Exception ex)
            {
                chromeMod.logger(ex.Message, ex);
            }
        }
    }
}

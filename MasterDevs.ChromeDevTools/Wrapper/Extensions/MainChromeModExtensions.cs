using System;
using System.Threading.Tasks;
using Mybot.ChromeDevTools.Protocol.Chrome.Page;

namespace Mybot.ChromeDevTools.Wrapper.Extensions
{
    public static class MainChromeModExtensions
    {
        /// <summary>
        /// Close browser
        /// </summary>
        /// <param name="chromeMod"></param>
        public static void Close(this ChromeMod chromeMod)
        {
            try
            {
                CommandResponse commandResponse = Task.Run(() => chromeMod.ChromeSession.SendAsync(new Protocol.Chrome.Browser.CloseCommand()))
                .ConfigureAwait(false).GetAwaiter().GetResult();
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
        }

        /// <summary>
        /// Navigate to url
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="url"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Reload page
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Go Back to prev. page
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Go Forward page
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <returns></returns>
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

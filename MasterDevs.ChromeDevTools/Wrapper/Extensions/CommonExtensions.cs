using System;
using System.Threading;
using Mybot.ChromeDevTools.Protocol.Chrome.DOM;

namespace Mybot.ChromeDevTools.Wrapper.Extensions
{
    public static class CommonExtensions
    {
        /// <summary>
        /// Получения ID корневого элемента
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <returns></returns>
        public static long? GetDocNodeID(this ChromeMod chromeMod)
        {
            try
            {
                CommandResponse<GetDocumentCommandResponse> cr = chromeMod.ChromeSession.SendAsync(new GetDocumentCommand())
                    .ConfigureAwait(false).GetAwaiter().GetResult();

                if (cr == null)
                {
                    chromeMod.logger("cr == null", null);
                    return null;
                }

                return cr.Result.Root.NodeId;
            }
            catch (Exception ex)
            {
                chromeMod.logger(ex.Message, ex);
                return null;
            }
        }

        /// <summary>
        /// Ожидает появления элемента, если таймаут 0, то возвращает false
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="cssSelector"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static bool AwaitElement(this ChromeMod chromeMod, string cssSelector, int timeout)
        {
            try
            {
                while (timeout > 0)
                {
                    timeout--;
                    bool isExist = chromeMod.IsElementExist(cssSelector) != null;
                    if (isExist)
                    {
                        return true;
                    }

                    Thread.Sleep(1000);
                }

                return false;
            }
            catch (Exception ex)
            {
                chromeMod.logger(ex.Message, ex);
                return false;
            }
        }

        /// <summary>
        /// Проверка существования элемента, возвращает Id элемента или null,если элемент не найден.
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="cssSelector"></param>
        /// <returns></returns>
        public static long? IsElementExist(this ChromeMod chromeMod, string cssSelector)
        {
            try
            {
                long? docNodeId = chromeMod.GetDocNodeID();
                if (docNodeId == null)
                {
                    return null;
                }

                CommandResponse<QuerySelectorCommandResponse> qs = chromeMod.ChromeSession.SendAsync(new QuerySelectorCommand
                {
                    NodeId = (long)docNodeId,
                    Selector = cssSelector
                }).ConfigureAwait(false).GetAwaiter().GetResult();

                return qs.Result.NodeId;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Проверка существования элемента с текстом
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="cssSelector"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static long? IsElementWithTextExist(this ChromeMod chromeMod, string cssSelector, string text)
        {
            try
            {
                long? docNodeId = chromeMod.GetDocNodeID();
                if (docNodeId == null)
                {
                    return null;
                }

                CommandResponse<QuerySelectorCommandResponse> qs = chromeMod.ChromeSession.SendAsync(new QuerySelectorCommand
                {
                    NodeId = (long)docNodeId,
                    Selector = cssSelector
                }).ConfigureAwait(false).GetAwaiter().GetResult();

                long nodeId = qs.Result.NodeId;
                CommandResponse<GetOuterHTMLCommandResponse> getHTML = chromeMod.ChromeSession.SendAsync(new GetOuterHTMLCommand { NodeId = nodeId })
                    .ConfigureAwait(false).GetAwaiter().GetResult();

                string outer = getHTML.Result.OuterHTML;

                return outer.Contains(text) ? nodeId : (long?)null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Получить текст из элемента
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="cssSelector"></param>
        /// <returns></returns>
        public static string GetText(this ChromeMod chromeMod, string cssSelector)
        {
            try
            {
                long? docNodeId = chromeMod.GetDocNodeID();
                if (docNodeId == null)
                {
                    return null;
                }

                CommandResponse<QuerySelectorCommandResponse> qs = chromeMod.ChromeSession.SendAsync(new QuerySelectorCommand
                {
                    NodeId = (long)docNodeId,
                    Selector = cssSelector
                }).ConfigureAwait(false).GetAwaiter().GetResult();
                long nodeId = qs.Result.NodeId;

                string text = chromeMod.ChromeSession.SendAsync(new GetOuterHTMLCommand { NodeId = nodeId })
                    .ConfigureAwait(false).GetAwaiter().GetResult().Result.OuterHTML;
                return text;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

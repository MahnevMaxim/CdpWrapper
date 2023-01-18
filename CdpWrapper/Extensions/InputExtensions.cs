using System;
using System.Threading;
using System.Threading.Tasks;
using Mybot.ChromeDevTools;
using Mybot.ChromeDevTools.Protocol.Chrome.DOM;
using Mybot.ChromeDevTools.Protocol.Chrome.Input;

namespace CdpWrapper.Extensions
{
    public static class InputExtensions
    {
        /// <summary>
        /// Click css-selector
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="cssSelector"></param>
        /// <returns></returns>
        public static CallResult Click(this ChromeMod chromeMod, string cssSelector)
        {
            try
            {
                long? docNodeId = chromeMod.GetDocNodeID();
                if (docNodeId == null)
                {
                    return new CallResult() { Error = new Error("document node id is null") };
                }

                CommandResponse<QuerySelectorCommandResponse> qsButton = chromeMod.ChromeSession.SendAsync(new QuerySelectorCommand
                {
                    NodeId = (long)docNodeId,
                    Selector = cssSelector
                }).Result;
                long elementNodeId = qsButton.Result.NodeId;

                Task<CommandResponse<GetBoxModelCommandResponse>> elementBox = chromeMod.ChromeSession.SendAsync(new GetBoxModelCommand
                {
                    NodeId = elementNodeId
                });
                BoxModel elementBoxRes = elementBox.Result.Result.Model;

                double leftBegin = elementBoxRes.Border[0];
                double leftEnd = elementBoxRes.Border[2];
                double topBegin = elementBoxRes.Border[1];
                double topEnd = elementBoxRes.Border[5];

                double x = Math.Round((leftBegin + leftEnd) / 2, 2);
                double y = Math.Round((topBegin + topEnd) / 2, 2);

                CommandResponse<DispatchMouseEventCommandResponse> click = chromeMod.ChromeSession.SendAsync(new DispatchMouseEventCommand
                {
                    Type = "mousePressed",
                    X = x,
                    Y = y,
                    ClickCount = 1,
                    Button = "left"
                }).ConfigureAwait(false).GetAwaiter().GetResult();

                Thread.Sleep(100);

                CommandResponse<DispatchMouseEventCommandResponse> clickReleased = chromeMod.ChromeSession.SendAsync(new DispatchMouseEventCommand
                {
                    Type = "mouseReleased",
                    X = x,
                    Y = y,
                    ClickCount = 1,
                    Button = "left"
                }).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                return new CallResult() { Error = new Error(ex) };
            }
            return new CallResult();
        }

        /// <summary>
        /// Click css-selector by instance
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="nodeId"></param>
        /// <returns></returns>
        public static CallResult Click(this ChromeMod chromeMod, long nodeId)
        {
            try
            {
                CommandResponse<GetBoxModelCommandResponse> elementBox = chromeMod.ChromeSession.SendAsync(new GetBoxModelCommand
                {
                    NodeId = nodeId
                }).ConfigureAwait(false).GetAwaiter().GetResult();
                BoxModel elementBoxRes = elementBox.Result.Model;

                double leftBegin = elementBoxRes.Border[0];
                double leftEnd = elementBoxRes.Border[2];
                double topBegin = elementBoxRes.Border[1];
                double topEnd = elementBoxRes.Border[5];

                double x = Math.Round((leftBegin + leftEnd) / 2, 2);
                double y = Math.Round((topBegin + topEnd) / 2, 2);

                CommandResponse<DispatchMouseEventCommandResponse> click = chromeMod.ChromeSession.SendAsync(new DispatchMouseEventCommand
                {
                    Type = "mousePressed",
                    X = x,
                    Y = y,
                    ClickCount = 1,
                    Button = "left"
                }).ConfigureAwait(false).GetAwaiter().GetResult();

                Thread.Sleep(100);

                CommandResponse<DispatchMouseEventCommandResponse> clickReleased = chromeMod.ChromeSession.SendAsync(new DispatchMouseEventCommand
                {
                    Type = "mouseReleased",
                    X = x,
                    Y = y,
                    ClickCount = 1,
                    Button = "left"
                }).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                return new CallResult() { Error = new Error(ex) };
            }
            return new CallResult();
        }

        /// <summary>
        /// Set text to element
        /// </summary>
        /// <param name="chromeMod"></param>
        /// <param name="cssSelector"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public static CallResult InsertText(this ChromeMod chromeMod, string cssSelector, string text)
        {
            try
            {
                long? docNodeId = chromeMod.GetDocNodeID();

                CommandResponse<QuerySelectorCommandResponse> qs = chromeMod.ChromeSession.SendAsync(new QuerySelectorCommand
                {
                    NodeId = (long)docNodeId,
                    Selector = cssSelector
                }).ConfigureAwait(false).GetAwaiter().GetResult();
                long elementNodeId = qs.Result.NodeId;

                CommandResponse<FocusCommandResponse> sv = chromeMod.ChromeSession.SendAsync(new FocusCommand
                {
                    NodeId = elementNodeId
                }).ConfigureAwait(false).GetAwaiter().GetResult();

                CommandResponse<InsertTextCommandResponse> it = chromeMod.ChromeSession.SendAsync(new InsertTextCommand
                {
                    Text = text
                }).ConfigureAwait(false).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                return new CallResult() { Error = new Error(ex) };
            }
            return new CallResult();
        }
    }
}

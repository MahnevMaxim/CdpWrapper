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

        public static async Task<CDPResponse> Click(this ChromeMod chromeMod, long nodeId)
        {
            CDPResponse cdpr = new CDPResponse();
            try
            {
                CommandResponse<GetBoxModelCommandResponse> elementBox = await chromeMod.ChromeSession.SendAsync(new GetBoxModelCommand
                {
                    NodeId = nodeId
                });
                BoxModel elementBoxRes = elementBox.Result.Model;

                double leftBegin = elementBoxRes.Border[0];
                double leftEnd = elementBoxRes.Border[2];
                double topBegin = elementBoxRes.Border[1];
                double topEnd = elementBoxRes.Border[5];

                double x = Math.Round((leftBegin + leftEnd) / 2, 2);
                double y = Math.Round((topBegin + topEnd) / 2, 2);

                Task<CommandResponse<DispatchMouseEventCommandResponse>> click = chromeMod.ChromeSession.SendAsync(new DispatchMouseEventCommand
                {
                    Type = "mousePressed",
                    X = x,
                    Y = y,
                    ClickCount = 1,
                    Button = "left"
                });

                await Task.Delay(100);

                Task<CommandResponse<DispatchMouseEventCommandResponse>> clickReleased = chromeMod.ChromeSession.SendAsync(new DispatchMouseEventCommand
                {
                    Type = "mouseReleased",
                    X = x,
                    Y = y,
                    ClickCount = 1,
                    Button = "left"
                });
            }
            catch (Exception ex)
            {
                cdpr.ErrorMessage = ex.Message;
            }
            return cdpr;
        }
    }
}

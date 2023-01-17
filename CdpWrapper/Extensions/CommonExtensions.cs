using System;
using Mybot.ChromeDevTools;
using Mybot.ChromeDevTools.Protocol.Chrome.DOM;

namespace CdpWrapper.Extensions
{
    public static class CommonExtensions
    {
        public static long? GetDocNodeID(this ChromeMod chromeMod)
        {
            try
            {
                CommandResponse<GetDocumentCommandResponse> cr = chromeMod.ChromeSession.SendAsync(new GetDocumentCommand()).ConfigureAwait(false).GetAwaiter().GetResult();
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
    }
}

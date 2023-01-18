#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	[Event(ProtocolName.Page.FrameResized)]
	[SupportedBy("Chrome")]
	public class FrameResizedEvent
	{
	}
}

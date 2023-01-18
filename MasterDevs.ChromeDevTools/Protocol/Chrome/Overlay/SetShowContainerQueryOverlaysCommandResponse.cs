#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	[CommandResponse(ProtocolName.Overlay.SetShowContainerQueryOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowContainerQueryOverlaysCommandResponse
	{
	}
}

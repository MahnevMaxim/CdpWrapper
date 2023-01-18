#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowFPSCounter)]
	[SupportedBy("Chrome")]
	public class SetShowFPSCounterCommandResponse
	{
	}
}

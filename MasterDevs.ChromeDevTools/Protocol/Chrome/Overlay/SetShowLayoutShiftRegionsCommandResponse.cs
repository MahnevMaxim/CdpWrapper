#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows layout shift regions
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowLayoutShiftRegions)]
	[SupportedBy("Chrome")]
	public class SetShowLayoutShiftRegionsCommandResponse
	{
	}
}

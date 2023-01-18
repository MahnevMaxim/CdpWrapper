#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowPaintRects)]
	[SupportedBy("Chrome")]
	public class SetShowPaintRectsCommandResponse
	{
	}
}

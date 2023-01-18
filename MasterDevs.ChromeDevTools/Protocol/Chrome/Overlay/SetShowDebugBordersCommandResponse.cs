#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Requests that backend shows debug borders on layers
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowDebugBorders)]
	[SupportedBy("Chrome")]
	public class SetShowDebugBordersCommandResponse
	{
	}
}

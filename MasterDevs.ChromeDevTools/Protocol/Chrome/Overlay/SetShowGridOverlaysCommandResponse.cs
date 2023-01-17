using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlight multiple elements with the CSS Grid overlay.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowGridOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowGridOverlaysCommandResponse
	{
	}
}

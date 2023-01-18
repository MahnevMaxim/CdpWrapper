#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommandResponse
	{
	}
}

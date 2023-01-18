#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or objectId must be specified.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.HighlightNode)]
	[SupportedBy("Chrome")]
	public class HighlightNodeCommandResponse
	{
	}
}

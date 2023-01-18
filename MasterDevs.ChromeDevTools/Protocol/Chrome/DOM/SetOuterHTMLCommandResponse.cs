#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetOuterHTML)]
	[SupportedBy("Chrome")]
	public class SetOuterHTMLCommandResponse
	{
	}
}

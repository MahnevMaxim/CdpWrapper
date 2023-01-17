using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets node value for a node with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetNodeValue)]
	[SupportedBy("Chrome")]
	public class SetNodeValueCommandResponse
	{
	}
}

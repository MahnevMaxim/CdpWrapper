#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RemoveNode)]
	[SupportedBy("Chrome")]
	public class RemoveNodeCommandResponse
	{
	}
}

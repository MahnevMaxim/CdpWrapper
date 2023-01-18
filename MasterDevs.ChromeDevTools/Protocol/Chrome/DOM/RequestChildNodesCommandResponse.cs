#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Requests that children of the node with given id are returned to the caller in form of `setChildNodes` events where not only immediate children are retrieved, but all children down to the specified depth.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RequestChildNodes)]
	[SupportedBy("Chrome")]
	public class RequestChildNodesCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Enables network tracking, network events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Network.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

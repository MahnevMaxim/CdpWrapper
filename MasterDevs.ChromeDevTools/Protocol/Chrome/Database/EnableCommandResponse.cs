#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Database
{
	/// <summary>
	/// Enables database tracking, database events will now be delivered to the client.
	/// </summary>
	[CommandResponse(ProtocolName.Database.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

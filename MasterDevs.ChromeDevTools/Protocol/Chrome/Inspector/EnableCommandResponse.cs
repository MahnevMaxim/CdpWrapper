using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Enables inspector domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

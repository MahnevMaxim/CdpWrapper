using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Continues execution until specific location is reached.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.ContinueToLocation)]
	[SupportedBy("Chrome")]
	public class ContinueToLocationCommandResponse
	{
	}
}

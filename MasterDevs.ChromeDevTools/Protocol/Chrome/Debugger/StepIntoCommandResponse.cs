using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps into the function call.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepInto)]
	[SupportedBy("Chrome")]
	public class StepIntoCommandResponse
	{
	}
}

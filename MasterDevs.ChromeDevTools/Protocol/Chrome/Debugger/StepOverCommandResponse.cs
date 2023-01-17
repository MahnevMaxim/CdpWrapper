using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepOver)]
	[SupportedBy("Chrome")]
	public class StepOverCommandResponse
	{
	}
}

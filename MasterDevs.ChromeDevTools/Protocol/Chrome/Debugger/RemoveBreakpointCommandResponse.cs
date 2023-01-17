using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RemoveBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveBreakpointCommandResponse
	{
	}
}

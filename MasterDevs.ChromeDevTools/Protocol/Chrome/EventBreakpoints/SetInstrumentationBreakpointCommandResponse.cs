using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.EventBreakpoints
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[CommandResponse(ProtocolName.EventBreakpoints.SetInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommandResponse
	{
	}
}

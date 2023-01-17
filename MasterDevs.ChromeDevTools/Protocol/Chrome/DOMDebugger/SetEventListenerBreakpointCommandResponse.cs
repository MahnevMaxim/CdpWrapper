using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetEventListenerBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetEventListenerBreakpointCommandResponse
	{
	}
}

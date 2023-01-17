using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveEventListenerBreakpointCommandResponse
	{
	}
}

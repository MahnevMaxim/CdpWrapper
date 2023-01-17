using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetDOMBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetDOMBreakpointCommandResponse
	{
	}
}

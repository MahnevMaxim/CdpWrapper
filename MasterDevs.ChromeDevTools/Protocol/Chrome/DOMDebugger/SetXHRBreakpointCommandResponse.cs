#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetXHRBreakpointCommandResponse
	{
	}
}

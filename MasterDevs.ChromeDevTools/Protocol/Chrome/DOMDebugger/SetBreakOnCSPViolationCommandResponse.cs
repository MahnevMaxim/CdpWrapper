using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular CSP violations.
	/// </summary>
	[CommandResponse(ProtocolName.DOMDebugger.SetBreakOnCSPViolation)]
	[SupportedBy("Chrome")]
	public class SetBreakOnCSPViolationCommandResponse
	{
	}
}

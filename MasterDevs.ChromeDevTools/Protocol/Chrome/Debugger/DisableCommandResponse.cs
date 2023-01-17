using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Disables debugger for given page.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

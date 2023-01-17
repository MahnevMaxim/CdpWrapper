using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// Disables tracking security state changes.
	/// </summary>
	[CommandResponse(ProtocolName.Security.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

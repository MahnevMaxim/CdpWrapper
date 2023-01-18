#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Disables the fetch domain.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

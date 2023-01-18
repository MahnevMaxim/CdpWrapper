#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetCookies)]
	[SupportedBy("Chrome")]
	public class SetCookiesCommandResponse
	{
	}
}

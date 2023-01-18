#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCookies)]
	[SupportedBy("Chrome")]
	public class ClearBrowserCookiesCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.ClearCookies)]
	[SupportedBy("Chrome")]
	public class ClearCookiesCommandResponse
	{
	}
}

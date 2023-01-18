#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Continues the request, optionally modifying some of its parameters.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.ContinueRequest)]
	[SupportedBy("Chrome")]
	public class ContinueRequestCommandResponse
	{
	}
}

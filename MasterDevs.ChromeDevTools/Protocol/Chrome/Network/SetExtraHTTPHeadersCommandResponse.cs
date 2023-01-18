#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Specifies whether to always send extra HTTP headers with the requests from this page.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetExtraHTTPHeaders)]
	[SupportedBy("Chrome")]
	public class SetExtraHTTPHeadersCommandResponse
	{
	}
}

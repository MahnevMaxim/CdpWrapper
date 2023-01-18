#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Blocks URLs from loading.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetBlockedURLs)]
	[SupportedBy("Chrome")]
	public class SetBlockedURLsCommandResponse
	{
	}
}

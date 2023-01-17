using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCache)]
	[SupportedBy("Chrome")]
	public class ClearBrowserCacheCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If `true`, cache will not be used.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetCacheDisabled)]
	[SupportedBy("Chrome")]
	public class SetCacheDisabledCommandResponse
	{
	}
}

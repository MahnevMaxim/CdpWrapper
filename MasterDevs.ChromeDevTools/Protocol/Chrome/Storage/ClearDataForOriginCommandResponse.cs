#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears storage for origin.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.ClearDataForOrigin)]
	[SupportedBy("Chrome")]
	public class ClearDataForOriginCommandResponse
	{
	}
}

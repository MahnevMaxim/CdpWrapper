#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Override quota for the specified origin
	/// </summary>
	[CommandResponse(ProtocolName.Storage.OverrideQuotaForOrigin)]
	[SupportedBy("Chrome")]
	public class OverrideQuotaForOriginCommandResponse
	{
	}
}

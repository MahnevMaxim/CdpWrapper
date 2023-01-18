#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Disable collecting and reporting metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Performance.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

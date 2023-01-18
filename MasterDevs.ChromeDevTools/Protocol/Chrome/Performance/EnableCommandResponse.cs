#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Enable collecting and reporting metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Performance.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Enable type profile.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.StartTypeProfile)]
	[SupportedBy("Chrome")]
	public class StartTypeProfileCommandResponse
	{
	}
}

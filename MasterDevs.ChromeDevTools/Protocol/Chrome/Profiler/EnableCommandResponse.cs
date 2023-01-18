#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	[CommandResponse(ProtocolName.Profiler.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

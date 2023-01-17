using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Crashes GPU process.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.CrashGpuProcess)]
	[SupportedBy("Chrome")]
	public class CrashGpuProcessCommandResponse
	{
	}
}

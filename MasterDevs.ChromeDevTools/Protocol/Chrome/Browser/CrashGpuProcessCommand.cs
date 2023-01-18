#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Crashes GPU process.
	/// </summary>
	[Command(ProtocolName.Browser.CrashGpuProcess)]
	[SupportedBy("Chrome")]
	public class CrashGpuProcessCommand: ICommand<CrashGpuProcessCommandResponse>
	{
	}
}

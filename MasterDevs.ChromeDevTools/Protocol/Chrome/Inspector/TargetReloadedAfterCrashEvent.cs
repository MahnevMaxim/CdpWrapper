#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Fired when debugging target has reloaded after crash
	/// </summary>
	[Event(ProtocolName.Inspector.TargetReloadedAfterCrash)]
	[SupportedBy("Chrome")]
	public class TargetReloadedAfterCrashEvent
	{
	}
}

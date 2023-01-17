using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Inspector
{
	/// <summary>
	/// Fired when debugging target has crashed
	/// </summary>
	[Event(ProtocolName.Inspector.TargetCrashed)]
	[SupportedBy("Chrome")]
	public class TargetCrashedEvent
	{
	}
}

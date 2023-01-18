#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Event(ProtocolName.HeapProfiler.ResetProfiles)]
	[SupportedBy("Chrome")]
	public class ResetProfilesEvent
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Record a clock sync marker in the trace.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.RecordClockSyncMarker)]
	[SupportedBy("Chrome")]
	public class RecordClockSyncMarkerCommandResponse
	{
	}
}

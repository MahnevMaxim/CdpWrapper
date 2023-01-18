#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.TakeHeapSnapshot)]
	[SupportedBy("Chrome")]
	public class TakeHeapSnapshotCommandResponse
	{
	}
}

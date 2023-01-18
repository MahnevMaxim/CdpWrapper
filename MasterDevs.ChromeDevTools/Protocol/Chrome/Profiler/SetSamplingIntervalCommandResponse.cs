#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.SetSamplingInterval)]
	[SupportedBy("Chrome")]
	public class SetSamplingIntervalCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.StopSampling)]
	[SupportedBy("Chrome")]
	public class StopSamplingCommandResponse
	{
		/// <summary>
		/// Gets or sets Recorded sampling heap profile.
		/// </summary>
		public SamplingHeapProfile Profile { get; set; }
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommandResponse
	{
		/// <summary>
		/// Gets or sets Return the sampling profile being collected.
		/// </summary>
		public SamplingHeapProfile Profile { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	/// <summary>
	/// Sampling profile.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SamplingHeapProfile
	{
		/// <summary>
		/// Gets or sets Head
		/// </summary>
		public SamplingHeapProfileNode Head { get; set; }
		/// <summary>
		/// Gets or sets Samples
		/// </summary>
		public SamplingHeapProfileSample[] Samples { get; set; }
	}
}

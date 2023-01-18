#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Current values of the metrics.
	/// </summary>
	[Event(ProtocolName.Performance.Metrics)]
	[SupportedBy("Chrome")]
	public class MetricsEvent
	{
		/// <summary>
		/// Gets or sets Current values of the metrics.
		/// </summary>
		public Metric[] Metrics { get; set; }
		/// <summary>
		/// Gets or sets Timestamp title.
		/// </summary>
		public string Title { get; set; }
	}
}

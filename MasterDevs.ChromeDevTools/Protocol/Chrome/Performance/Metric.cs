using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Performance
{
	/// <summary>
	/// Run-time execution metric.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Metric
	{
		/// <summary>
		/// Gets or sets Metric name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Metric value.
		/// </summary>
		public double Value { get; set; }
	}
}

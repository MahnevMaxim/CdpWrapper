#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// CSS Shape Outside details.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ShapeOutsideInfo
	{
		/// <summary>
		/// Gets or sets Shape bounds
		/// </summary>
		public double[] Bounds { get; set; }
		/// <summary>
		/// Gets or sets Shape coordinate details
		/// </summary>
		public object[] Shape { get; set; }
		/// <summary>
		/// Gets or sets Margin shape bounds
		/// </summary>
		public object[] MarginShape { get; set; }
	}
}

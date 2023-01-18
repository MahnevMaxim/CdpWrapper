#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// Data that is only present on rare nodes.
	/// </summary>
	[SupportedBy("Chrome")]
	public class RareStringData
	{
		/// <summary>
		/// Gets or sets Index
		/// </summary>
		public long[] Index { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		public long[] Value { get; set; }
	}
}

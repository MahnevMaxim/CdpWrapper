using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	[SupportedBy("Chrome")]
	public class RareIntegerData
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

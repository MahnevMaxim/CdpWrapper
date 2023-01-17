using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Debug symbols available for a wasm script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class DebugSymbols
	{
		/// <summary>
		/// Gets or sets Type of the debug symbols.
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets URL of the external symbol source.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ExternalURL { get; set; }
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class IsolatedElementHighlightConfig
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance of an element in isolation mode.
		/// </summary>
		public IsolationModeHighlightConfig IsolationModeHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the isolated element to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}

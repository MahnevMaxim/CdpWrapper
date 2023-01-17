using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class IsolationModeHighlightConfig
	{
		/// <summary>
		/// Gets or sets The fill color of the resizers (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ResizerColor { get; set; }
		/// <summary>
		/// Gets or sets The fill color for resizer handles (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ResizerHandleColor { get; set; }
		/// <summary>
		/// Gets or sets The fill color for the mask covering non-isolated elements (default: transparent).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA MaskColor { get; set; }
	}
}

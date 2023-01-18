#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Accessibility
{
	[SupportedBy("Chrome")]
	public class AXRelatedNode
	{
		/// <summary>
		/// Gets or sets The BackendNodeId of the related DOM node.
		/// </summary>
		public long BackendDOMNodeId { get; set; }
		/// <summary>
		/// Gets or sets The IDRef value provided, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Idref { get; set; }
		/// <summary>
		/// Gets or sets The text alternative of this node in the current context.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }
	}
}

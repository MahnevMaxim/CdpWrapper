using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ContainerQueryHighlightConfig
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance of container query containers.
		/// </summary>
		public ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the container node to highlight.
		/// </summary>
		public long NodeId { get; set; }
	}
}

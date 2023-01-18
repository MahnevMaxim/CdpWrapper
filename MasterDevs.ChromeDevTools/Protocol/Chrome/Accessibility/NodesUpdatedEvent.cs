#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
	/// </summary>
	[Event(ProtocolName.Accessibility.NodesUpdated)]
	[SupportedBy("Chrome")]
	public class NodesUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Updated node data.
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}

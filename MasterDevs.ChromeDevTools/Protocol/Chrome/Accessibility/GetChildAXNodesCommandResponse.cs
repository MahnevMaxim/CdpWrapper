#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches a particular accessibility node by AXNodeId. Requires `enable()` to have been called previously.
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.GetChildAXNodes)]
	[SupportedBy("Chrome")]
	public class GetChildAXNodesCommandResponse
	{
		/// <summary>
		/// Gets or sets Nodes
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}

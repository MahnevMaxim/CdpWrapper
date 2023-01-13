using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches a node and all ancestors up to and including the root. Requires `enable()` to have been called previously.
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.GetAXNodeAndAncestors)]
	[SupportedBy("Chrome")]
	public class GetAXNodeAndAncestorsCommandResponse
	{
		/// <summary>
		/// Gets or sets Nodes
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}

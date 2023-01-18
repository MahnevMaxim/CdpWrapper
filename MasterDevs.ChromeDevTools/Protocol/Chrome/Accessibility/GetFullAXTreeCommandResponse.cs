#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches the entire accessibility tree for the root Document
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.GetFullAXTree)]
	[SupportedBy("Chrome")]
	public class GetFullAXTreeCommandResponse
	{
		/// <summary>
		/// Gets or sets Nodes
		/// </summary>
		public AXNode[] Nodes { get; set; }
	}
}

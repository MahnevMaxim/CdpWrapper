using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches the root node. Requires `enable()` to have been called previously.
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.GetRootAXNode)]
	[SupportedBy("Chrome")]
	public class GetRootAXNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Node
		/// </summary>
		public AXNode Node { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Creates a deep copy of the specified node and places it into the target container before the given anchor.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.CopyTo)]
	[SupportedBy("Chrome")]
	public class CopyToCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node clone.
		/// </summary>
		public long NodeId { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Collects class names for the node with given id and all of it's child nodes.
	/// </summary>
	[Command(ProtocolName.DOM.CollectClassNamesFromSubtree)]
	[SupportedBy("Chrome")]
	public class CollectClassNamesFromSubtreeCommand: ICommand<CollectClassNamesFromSubtreeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to collect class names.
		/// </summary>
		public long NodeId { get; set; }
	}
}

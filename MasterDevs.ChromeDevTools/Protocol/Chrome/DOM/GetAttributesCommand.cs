using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns attributes for the specified node.
	/// </summary>
	[Command(ProtocolName.DOM.GetAttributes)]
	[SupportedBy("Chrome")]
	public class GetAttributesCommand: ICommand<GetAttributesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the node to retrieve attibutes for.
		/// </summary>
		public long NodeId { get; set; }
	}
}

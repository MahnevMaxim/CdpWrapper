using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Fetches a node and all ancestors up to and including the root. Requires `enable()` to have been called previously.
	/// </summary>
	[Command(ProtocolName.Accessibility.GetAXNodeAndAncestors)]
	[SupportedBy("Chrome")]
	public class GetAXNodeAndAncestorsCommand: ICommand<GetAXNodeAndAncestorsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the node to get.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the backend node to get.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets JavaScript object id of the node wrapper to get.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}

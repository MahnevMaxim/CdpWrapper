using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its path. // FIXME, use XPath
	/// </summary>
	[CommandResponse(ProtocolName.DOM.PushNodeByPathToFrontend)]
	[SupportedBy("Chrome")]
	public class PushNodeByPathToFrontendCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node for given path.
		/// </summary>
		public long NodeId { get; set; }
	}
}

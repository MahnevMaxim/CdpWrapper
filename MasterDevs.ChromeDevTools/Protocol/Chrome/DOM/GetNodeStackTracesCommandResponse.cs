using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Gets stack traces associated with a Node. As of now, only provides stack trace for Node creation.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetNodeStackTraces)]
	[SupportedBy("Chrome")]
	public class GetNodeStackTracesCommandResponse
	{
		/// <summary>
		/// Gets or sets Creation stack trace, if available.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace Creation { get; set; }
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// For testing.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.GetHighlightObjectForTest)]
	[SupportedBy("Chrome")]
	public class GetHighlightObjectForTestCommandResponse
	{
		/// <summary>
		/// Gets or sets Highlight data for the node.
		/// </summary>
		public object Highlight { get; set; }
	}
}

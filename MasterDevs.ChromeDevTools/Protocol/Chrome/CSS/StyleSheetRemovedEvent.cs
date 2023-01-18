#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is removed.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetRemoved)]
	[SupportedBy("Chrome")]
	public class StyleSheetRemovedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the removed stylesheet.
		/// </summary>
		public string StyleSheetId { get; set; }
	}
}

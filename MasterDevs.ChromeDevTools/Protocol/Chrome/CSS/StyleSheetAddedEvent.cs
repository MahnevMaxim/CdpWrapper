#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is added.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetAdded)]
	[SupportedBy("Chrome")]
	public class StyleSheetAddedEvent
	{
		/// <summary>
		/// Gets or sets Added stylesheet metainfo.
		/// </summary>
		public CSSStyleSheetHeader Header { get; set; }
	}
}

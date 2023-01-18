#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when the page with currently enabled screencast was shown or hidden `.
	/// </summary>
	[Event(ProtocolName.Page.ScreencastVisibilityChanged)]
	[SupportedBy("Chrome")]
	public class ScreencastVisibilityChangedEvent
	{
		/// <summary>
		/// Gets or sets True if the page is visible.
		/// </summary>
		public bool Visible { get; set; }
	}
}

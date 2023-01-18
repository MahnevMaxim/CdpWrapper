#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when frame has stopped loading.
	/// </summary>
	[Event(ProtocolName.Page.FrameStoppedLoading)]
	[SupportedBy("Chrome")]
	public class FrameStoppedLoadingEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has stopped loading.
		/// </summary>
		public string FrameId { get; set; }
	}
}

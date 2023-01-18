#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when frame has started loading.
	/// </summary>
	[Event(ProtocolName.Page.FrameStartedLoading)]
	[SupportedBy("Chrome")]
	public class FrameStartedLoadingEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has started loading.
		/// </summary>
		public string FrameId { get; set; }
	}
}

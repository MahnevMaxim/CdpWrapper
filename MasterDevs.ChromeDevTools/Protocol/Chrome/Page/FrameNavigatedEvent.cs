using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
	/// </summary>
	[Event(ProtocolName.Page.FrameNavigated)]
	[SupportedBy("Chrome")]
	public class FrameNavigatedEvent
	{
		/// <summary>
		/// Gets or sets Frame object.
		/// </summary>
		public Frame Frame { get; set; }
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public NavigationType Type { get; set; }
	}
}

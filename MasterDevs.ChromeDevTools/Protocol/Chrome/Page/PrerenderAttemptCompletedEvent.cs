using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when a prerender attempt is completed.
	/// </summary>
	[Event(ProtocolName.Page.PrerenderAttemptCompleted)]
	[SupportedBy("Chrome")]
	public class PrerenderAttemptCompletedEvent
	{
		/// <summary>
		/// Gets or sets The frame id of the frame initiating prerendering.
		/// </summary>
		public string InitiatingFrameId { get; set; }
		/// <summary>
		/// Gets or sets PrerenderingUrl
		/// </summary>
		public string PrerenderingUrl { get; set; }
		/// <summary>
		/// Gets or sets FinalStatus
		/// </summary>
		public PrerenderFinalStatus FinalStatus { get; set; }
	}
}

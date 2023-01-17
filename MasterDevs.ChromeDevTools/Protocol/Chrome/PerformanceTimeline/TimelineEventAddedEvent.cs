using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	/// <summary>
	/// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
	/// </summary>
	[Event(ProtocolName.PerformanceTimeline.TimelineEventAdded)]
	[SupportedBy("Chrome")]
	public class TimelineEventAddedEvent
	{
		/// <summary>
		/// Gets or sets Event
		/// </summary>
		public TimelineEvent Event { get; set; }
	}
}

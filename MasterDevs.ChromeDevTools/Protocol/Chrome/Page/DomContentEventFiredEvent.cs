#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	[Event(ProtocolName.Page.DomContentEventFired)]
	[SupportedBy("Chrome")]
	public class DomContentEventFiredEvent
	{
		/// <summary>
		/// Gets or sets Timestamp
		/// </summary>
		public double Timestamp { get; set; }
	}
}

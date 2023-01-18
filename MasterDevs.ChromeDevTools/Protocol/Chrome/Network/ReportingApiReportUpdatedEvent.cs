#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	[Event(ProtocolName.Network.ReportingApiReportUpdated)]
	[SupportedBy("Chrome")]
	public class ReportingApiReportUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Report
		/// </summary>
		public ReportingApiReport Report { get; set; }
	}
}

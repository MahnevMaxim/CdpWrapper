#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits
{
	[Event(ProtocolName.Audits.IssueAdded)]
	[SupportedBy("Chrome")]
	public class IssueAddedEvent
	{
		/// <summary>
		/// Gets or sets Issue
		/// </summary>
		public InspectorIssue Issue { get; set; }
	}
}

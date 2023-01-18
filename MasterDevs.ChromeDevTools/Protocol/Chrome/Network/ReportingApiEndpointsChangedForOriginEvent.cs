#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	[Event(ProtocolName.Network.ReportingApiEndpointsChangedForOrigin)]
	[SupportedBy("Chrome")]
	public class ReportingApiEndpointsChangedForOriginEvent
	{
		/// <summary>
		/// Gets or sets Origin of the document(s) which configured the endpoints.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Endpoints
		/// </summary>
		public ReportingApiEndpoint[] Endpoints { get; set; }
	}
}

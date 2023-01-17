using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class ReportingApiEndpoint
	{
		/// <summary>
		/// Gets or sets The URL of the endpoint to which reports may be delivered.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Name of the endpoint group.
		/// </summary>
		public string GroupName { get; set; }
	}
}

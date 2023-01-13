using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class FederatedAuthRequestIssueDetails
	{
		/// <summary>
		/// Gets or sets FederatedAuthRequestIssueReason
		/// </summary>
		public FederatedAuthRequestIssueReason FederatedAuthRequestIssueReason { get; set; }
	}
}

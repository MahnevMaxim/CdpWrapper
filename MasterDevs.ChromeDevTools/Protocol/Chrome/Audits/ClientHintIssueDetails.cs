using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// This issue tracks client hints related issues. It's used to deprecate old features, encourage the use of new ones, and provide general guidance.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ClientHintIssueDetails
	{
		/// <summary>
		/// Gets or sets SourceCodeLocation
		/// </summary>
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or sets ClientHintIssueReason
		/// </summary>
		public ClientHintIssueReason ClientHintIssueReason { get; set; }
	}
}

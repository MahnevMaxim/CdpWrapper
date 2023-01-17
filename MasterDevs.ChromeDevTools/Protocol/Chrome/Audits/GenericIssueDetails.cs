using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Depending on the concrete errorType, different properties are set.
	/// </summary>
	[SupportedBy("Chrome")]
	public class GenericIssueDetails
	{
		/// <summary>
		/// Gets or sets Issues with the same errorType are aggregated in the frontend.
		/// </summary>
		public GenericIssueErrorType ErrorType { get; set; }
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}

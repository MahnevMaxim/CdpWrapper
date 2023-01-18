#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// This issue tracks information needed to print a deprecation message. https://source.chromium.org/chromium/chromium/src/+/main:third_party/blink/renderer/core/frame/third_party/blink/renderer/core/frame/deprecation/README.md
	/// </summary>
	[SupportedBy("Chrome")]
	public class DeprecationIssueDetails
	{
		/// <summary>
		/// Gets or sets AffectedFrame
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame AffectedFrame { get; set; }
		/// <summary>
		/// Gets or sets SourceCodeLocation
		/// </summary>
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public DeprecationIssueType Type { get; set; }
	}
}

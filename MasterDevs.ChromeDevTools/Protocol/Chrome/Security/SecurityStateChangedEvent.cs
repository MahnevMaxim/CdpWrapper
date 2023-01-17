using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	/// The security state of the page changed. No longer being sent.
	/// </summary>
	[Event(ProtocolName.Security.SecurityStateChanged)]
	[SupportedBy("Chrome")]
	public class SecurityStateChangedEvent
	{
		/// <summary>
		/// Gets or sets Security state.
		/// </summary>
		public SecurityState SecurityState { get; set; }
		/// <summary>
		/// Gets or sets True if the page was loaded over cryptographic transport such as HTTPS.
		/// </summary>
		public bool SchemeIsCryptographic { get; set; }
		/// <summary>
		/// Gets or sets Previously a list of explanations for the security state. Now always empty.
		/// </summary>
		public SecurityStateExplanation[] Explanations { get; set; }
		/// <summary>
		/// Gets or sets Information about insecure content on the page.
		/// </summary>
		public InsecureContentStatus InsecureContentStatus { get; set; }
		/// <summary>
		/// Gets or sets Overrides user-visible description of the state. Always omitted.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Summary { get; set; }
	}
}

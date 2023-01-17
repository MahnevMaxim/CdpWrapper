using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class SecurityIsolationStatus
	{
		/// <summary>
		/// Gets or sets Coop
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CrossOriginOpenerPolicyStatus Coop { get; set; }
		/// <summary>
		/// Gets or sets Coep
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CrossOriginEmbedderPolicyStatus Coep { get; set; }
	}
}

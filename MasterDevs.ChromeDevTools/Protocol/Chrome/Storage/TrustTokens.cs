#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Pair of issuer origin and number of available (signed, but not used) Trust Tokens from that issuer.
	/// </summary>
	[SupportedBy("Chrome")]
	public class TrustTokens
	{
		/// <summary>
		/// Gets or sets IssuerOrigin
		/// </summary>
		public string IssuerOrigin { get; set; }
		/// <summary>
		/// Gets or sets Count
		/// </summary>
		public double Count { get; set; }
	}
}

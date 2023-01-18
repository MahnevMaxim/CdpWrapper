#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// The full details of an interest group.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InterestGroupDetails
	{
		/// <summary>
		/// Gets or sets OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets ExpirationTime
		/// </summary>
		public double ExpirationTime { get; set; }
		/// <summary>
		/// Gets or sets JoiningOrigin
		/// </summary>
		public string JoiningOrigin { get; set; }
		/// <summary>
		/// Gets or sets BiddingUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BiddingUrl { get; set; }
		/// <summary>
		/// Gets or sets BiddingWasmHelperUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BiddingWasmHelperUrl { get; set; }
		/// <summary>
		/// Gets or sets UpdateUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UpdateUrl { get; set; }
		/// <summary>
		/// Gets or sets TrustedBiddingSignalsUrl
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TrustedBiddingSignalsUrl { get; set; }
		/// <summary>
		/// Gets or sets TrustedBiddingSignalsKeys
		/// </summary>
		public string[] TrustedBiddingSignalsKeys { get; set; }
		/// <summary>
		/// Gets or sets UserBiddingSignals
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UserBiddingSignals { get; set; }
		/// <summary>
		/// Gets or sets Ads
		/// </summary>
		public InterestGroupAd[] Ads { get; set; }
		/// <summary>
		/// Gets or sets AdComponents
		/// </summary>
		public InterestGroupAd[] AdComponents { get; set; }
	}
}

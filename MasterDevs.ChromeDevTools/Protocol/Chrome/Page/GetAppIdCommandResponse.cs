#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns the unique (PWA) app id. Only returns values if the feature flag 'WebAppEnableManifestId' is enabled
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetAppId)]
	[SupportedBy("Chrome")]
	public class GetAppIdCommandResponse
	{
		/// <summary>
		/// Gets or sets App id, either from manifest's id attribute or computed from start_url
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AppId { get; set; }
		/// <summary>
		/// Gets or sets Recommendation for manifest's id attribute to match current id computed from start_url
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RecommendedId { get; set; }
	}
}

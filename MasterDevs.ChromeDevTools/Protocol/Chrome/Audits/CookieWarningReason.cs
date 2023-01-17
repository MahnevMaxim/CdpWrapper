using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookieWarningReason
	{
			WarnSameSiteUnspecifiedCrossSiteContext,
			WarnSameSiteNoneInsecure,
			WarnSameSiteUnspecifiedLaxAllowUnsafe,
			WarnSameSiteStrictLaxDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeStrict,
			WarnSameSiteStrictCrossDowngradeLax,
			WarnSameSiteLaxCrossDowngradeStrict,
			WarnSameSiteLaxCrossDowngradeLax,
			WarnAttributeValueExceedsMaxSize,
	}
}

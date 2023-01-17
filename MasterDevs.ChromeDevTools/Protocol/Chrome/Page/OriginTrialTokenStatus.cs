using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Origin Trial(https://www.chromium.org/blink/origin-trials) support. Status for an Origin Trial token.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OriginTrialTokenStatus
	{
			Success,
			NotSupported,
			Insecure,
			Expired,
			WrongOrigin,
			InvalidSignature,
			Malformed,
			WrongVersion,
			FeatureDisabled,
			TokenDisabled,
			FeatureDisabledForUser,
			UnknownTrial,
	}
}

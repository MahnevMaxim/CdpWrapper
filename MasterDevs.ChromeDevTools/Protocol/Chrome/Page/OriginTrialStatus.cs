#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Status for an Origin Trial.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum OriginTrialStatus
	{
			Enabled,
			ValidTokenNotProvided,
			OSNotSupported,
			TrialNotAllowed,
	}
}

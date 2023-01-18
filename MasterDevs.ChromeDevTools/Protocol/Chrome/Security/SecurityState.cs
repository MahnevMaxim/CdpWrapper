#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Security{
	/// <summary>
	/// The security level of a page or resource.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SecurityState
	{
			Unknown,
			Neutral,
			Insecure,
			Secure,
			Info,
			[EnumMember(Value = "insecure-broken")]
			Insecure_broken,
	}
}

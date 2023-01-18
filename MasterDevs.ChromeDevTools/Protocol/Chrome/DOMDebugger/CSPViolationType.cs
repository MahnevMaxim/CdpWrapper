#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger{
	/// <summary>
	/// CSP Violation type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CSPViolationType
	{
			[EnumMember(Value = "trustedtype-sink-violation")]
			Trustedtype_sink_violation,
			[EnumMember(Value = "trustedtype-policy-violation")]
			Trustedtype_policy_violation,
	}
}

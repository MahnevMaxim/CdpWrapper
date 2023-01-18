#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Loading priority of a resource request.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ResourcePriority
	{
			VeryLow,
			Low,
			Medium,
			High,
			VeryHigh,
	}
}

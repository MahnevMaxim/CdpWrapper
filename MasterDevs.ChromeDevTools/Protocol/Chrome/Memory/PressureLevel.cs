using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory{
	/// <summary>
	/// Memory pressure level.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PressureLevel
	{
			Moderate,
			Critical,
	}
}

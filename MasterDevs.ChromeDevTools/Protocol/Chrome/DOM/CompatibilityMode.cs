#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM{
	/// <summary>
	/// Document compatibility mode.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CompatibilityMode
	{
			QuirksMode,
			LimitedQuirksMode,
			NoQuirksMode,
	}
}

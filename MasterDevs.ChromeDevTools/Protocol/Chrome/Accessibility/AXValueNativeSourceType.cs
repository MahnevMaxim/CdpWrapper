#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Accessibility{
	/// <summary>
	/// Enum of possible native property sources (as a subtype of a particular AXValueSourceType).
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AXValueNativeSourceType
	{
			Description,
			Figcaption,
			Label,
			Labelfor,
			Labelwrapped,
			Legend,
			Rubyannotation,
			Tablecaption,
			Title,
			Other,
	}
}

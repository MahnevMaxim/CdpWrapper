using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Javascript dialog type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DialogType
	{
			Alert,
			Confirm,
			Prompt,
			Beforeunload,
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger{
	/// <summary>
	/// Enum of possible script languages.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ScriptLanguage
	{
			JavaScript,
			WebAssembly,
	}
}

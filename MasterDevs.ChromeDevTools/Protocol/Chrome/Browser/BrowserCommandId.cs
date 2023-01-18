#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser{
	/// <summary>
	/// Browser command ids used by executeBrowserCommand.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BrowserCommandId
	{
			OpenTabSearch,
			CloseTabSearch,
	}
}

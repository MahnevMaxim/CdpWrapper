#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// The type of a frameNavigated event.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NavigationType
	{
			Navigation,
			BackForwardCacheRestore,
	}
}

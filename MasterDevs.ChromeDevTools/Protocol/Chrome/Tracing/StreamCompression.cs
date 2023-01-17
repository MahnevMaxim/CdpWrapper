using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Tracing{
	/// <summary>
	/// Compression type to use for traces returned via streams.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StreamCompression
	{
			None,
			Gzip,
	}
}

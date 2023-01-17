using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// List of content encodings supported by the backend.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContentEncoding
	{
			Deflate,
			Gzip,
			Br,
	}
}

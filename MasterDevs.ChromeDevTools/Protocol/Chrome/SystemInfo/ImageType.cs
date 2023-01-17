using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.SystemInfo{
	/// <summary>
	/// Image format of a given image.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ImageType
	{
			Jpeg,
			Webp,
			Unknown,
	}
}

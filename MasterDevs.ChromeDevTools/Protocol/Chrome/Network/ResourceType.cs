using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Resource type as it was perceived by the rendering engine.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ResourceType
	{
			Document,
			Stylesheet,
			Image,
			Media,
			Font,
			Script,
			TextTrack,
			XHR,
			Fetch,
			Prefetch,
			EventSource,
			WebSocket,
			Manifest,
			SignedExchange,
			Ping,
			CSPViolationReport,
			Preflight,
			Other,
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InspectMode
	{
			SearchForNode,
			SearchForUAShadowDOM,
			CaptureAreaScreenshot,
			ShowDistances,
			None,
	}
}

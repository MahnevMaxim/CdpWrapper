using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Reason for a permissions policy feature to be disabled.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PermissionsPolicyBlockReason
	{
			Header,
			IframeAttribute,
			InFencedFrameTree,
			InIsolatedApp,
	}
}

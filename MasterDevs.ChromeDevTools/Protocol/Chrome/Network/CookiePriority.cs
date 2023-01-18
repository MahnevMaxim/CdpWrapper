#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	/// Represents the cookie's 'Priority' status: https://tools.ietf.org/html/draft-west-cookie-priority-00
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookiePriority
	{
			Low,
			Medium,
			High,
	}
}

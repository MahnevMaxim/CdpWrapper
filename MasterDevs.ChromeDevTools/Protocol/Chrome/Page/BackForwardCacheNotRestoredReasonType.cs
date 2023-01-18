#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// Types of not restored reasons for back-forward cache.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BackForwardCacheNotRestoredReasonType
	{
			SupportPending,
			PageSupportNeeded,
			Circumstantial,
	}
}

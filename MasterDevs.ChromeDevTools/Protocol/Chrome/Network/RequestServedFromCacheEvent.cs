using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired if request ended up loading from cache.
	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromCache)]
	[SupportedBy("Chrome")]
	public class RequestServedFromCacheEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
	}
}

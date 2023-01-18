#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Fetches cache entry.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.RequestCachedResponse)]
	[SupportedBy("Chrome")]
	public class RequestCachedResponseCommandResponse
	{
		/// <summary>
		/// Gets or sets Response read from the cache.
		/// </summary>
		public CachedResponse Response { get; set; }
	}
}

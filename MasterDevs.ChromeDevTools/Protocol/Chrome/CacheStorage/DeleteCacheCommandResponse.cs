#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.DeleteCache)]
	[SupportedBy("Chrome")]
	public class DeleteCacheCommandResponse
	{
	}
}

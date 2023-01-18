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
	[Command(ProtocolName.CacheStorage.DeleteCache)]
	[SupportedBy("Chrome")]
	public class DeleteCacheCommand: ICommand<DeleteCacheCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of cache for deletion.
		/// </summary>
		public string CacheId { get; set; }
	}
}

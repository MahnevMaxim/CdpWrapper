#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// A cache has been added/deleted.
	/// </summary>
	[Event(ProtocolName.Storage.CacheStorageListUpdated)]
	[SupportedBy("Chrome")]
	public class CacheStorageListUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Origin to update.
		/// </summary>
		public string Origin { get; set; }
	}
}

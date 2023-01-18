#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	/// <summary>
	/// DOM Storage identifier.
	/// </summary>
	[SupportedBy("Chrome")]
	public class StorageId
	{
		/// <summary>
		/// Gets or sets Security origin for the storage.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Represents a key by which DOM Storage keys its CachedStorageAreas
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets Whether the storage is local storage (not session storage).
		/// </summary>
		public bool IsLocalStorage { get; set; }
	}
}

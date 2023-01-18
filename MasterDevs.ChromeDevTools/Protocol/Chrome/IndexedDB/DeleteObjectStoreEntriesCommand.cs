#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Delete a range of entries from an object store
	/// </summary>
	[Command(ProtocolName.IndexedDB.DeleteObjectStoreEntries)]
	[SupportedBy("Chrome")]
	public class DeleteObjectStoreEntriesCommand: ICommand<DeleteObjectStoreEntriesCommandResponse>
	{
		/// <summary>
		/// Gets or sets At least and at most one of securityOrigin, storageKey must be specified. Security origin.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or sets Storage key.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets DatabaseName
		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or sets ObjectStoreName
		/// </summary>
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Gets or sets Range of entry keys to delete
		/// </summary>
		public KeyRange KeyRange { get; set; }
	}
}

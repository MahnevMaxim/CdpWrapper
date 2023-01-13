using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns a storage key given a frame id.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetStorageKeyForFrame)]
	[SupportedBy("Chrome")]
	public class GetStorageKeyForFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets StorageKey
		/// </summary>
		public string StorageKey { get; set; }
	}
}

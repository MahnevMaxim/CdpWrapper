using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Returns a storage key given a frame id.
	/// </summary>
	[Command(ProtocolName.Storage.GetStorageKeyForFrame)]
	[SupportedBy("Chrome")]
	public class GetStorageKeyForFrameCommand: ICommand<GetStorageKeyForFrameCommandResponse>
	{
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}

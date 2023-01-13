using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Clears storage for storage key.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.ClearDataForStorageKey)]
	[SupportedBy("Chrome")]
	public class ClearDataForStorageKeyCommandResponse
	{
	}
}

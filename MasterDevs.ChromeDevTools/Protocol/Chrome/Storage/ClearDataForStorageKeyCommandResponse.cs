using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
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

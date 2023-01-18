#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Clears all entries from an object store.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.ClearObjectStore)]
	[SupportedBy("Chrome")]
	public class ClearObjectStoreCommandResponse
	{
	}
}

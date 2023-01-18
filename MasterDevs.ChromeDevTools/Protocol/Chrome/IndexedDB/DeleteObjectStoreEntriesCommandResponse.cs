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
	[CommandResponse(ProtocolName.IndexedDB.DeleteObjectStoreEntries)]
	[SupportedBy("Chrome")]
	public class DeleteObjectStoreEntriesCommandResponse
	{
	}
}

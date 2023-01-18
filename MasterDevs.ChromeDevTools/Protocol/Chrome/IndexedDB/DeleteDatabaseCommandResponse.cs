#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Deletes a database.
	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.DeleteDatabase)]
	[SupportedBy("Chrome")]
	public class DeleteDatabaseCommandResponse
	{
	}
}

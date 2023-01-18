#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	/// Deletes a cache entry.
	/// </summary>
	[CommandResponse(ProtocolName.CacheStorage.DeleteEntry)]
	[SupportedBy("Chrome")]
	public class DeleteEntryCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Discards collected exceptions and console API calls.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.DiscardConsoleEntries)]
	[SupportedBy("Chrome")]
	public class DiscardConsoleEntriesCommandResponse
	{
	}
}

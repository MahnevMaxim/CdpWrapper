#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Tries to close page, running its beforeunload hooks, if any.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Close)]
	[SupportedBy("Chrome")]
	public class CloseCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Enables page domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

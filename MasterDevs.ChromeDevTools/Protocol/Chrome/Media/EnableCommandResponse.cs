#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Enables the Media domain
	/// </summary>
	[CommandResponse(ProtocolName.Media.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

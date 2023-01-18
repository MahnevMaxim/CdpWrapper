#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Disables the CSS agent for the given page.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

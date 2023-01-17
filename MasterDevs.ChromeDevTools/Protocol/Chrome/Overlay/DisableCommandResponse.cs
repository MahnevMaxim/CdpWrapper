using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Disables domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

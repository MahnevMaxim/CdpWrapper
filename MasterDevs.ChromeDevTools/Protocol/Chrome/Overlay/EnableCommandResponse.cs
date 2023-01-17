using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Enables domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

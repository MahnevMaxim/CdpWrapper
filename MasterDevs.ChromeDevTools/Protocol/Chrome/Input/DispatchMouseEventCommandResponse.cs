using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a mouse event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchMouseEvent)]
	[SupportedBy("Chrome")]
	public class DispatchMouseEventCommandResponse
	{
	}
}

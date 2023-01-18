#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a key event to the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchKeyEvent)]
	[SupportedBy("Chrome")]
	public class DispatchKeyEventCommandResponse
	{
	}
}

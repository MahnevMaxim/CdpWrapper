#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Starts sending each frame using the `screencastFrame` event.
	/// </summary>
	[CommandResponse(ProtocolName.Page.StartScreencast)]
	[SupportedBy("Chrome")]
	public class StartScreencastCommandResponse
	{
	}
}

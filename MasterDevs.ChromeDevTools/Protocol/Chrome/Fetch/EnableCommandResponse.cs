#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Enables issuing of requestPaused events. A request will be paused until client calls one of failRequest, fulfillRequest or continueRequest/continueWithAuth.
	/// </summary>
	[CommandResponse(ProtocolName.Fetch.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

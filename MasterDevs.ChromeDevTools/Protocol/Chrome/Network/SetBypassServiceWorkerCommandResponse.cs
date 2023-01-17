using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Toggles ignoring of service worker for each request.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetBypassServiceWorker)]
	[SupportedBy("Chrome")]
	public class SetBypassServiceWorkerCommandResponse
	{
	}
}

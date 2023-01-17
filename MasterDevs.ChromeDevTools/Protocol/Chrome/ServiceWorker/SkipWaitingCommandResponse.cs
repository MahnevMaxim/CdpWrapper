using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.SkipWaiting)]
	[SupportedBy("Chrome")]
	public class SkipWaitingCommandResponse
	{
	}
}

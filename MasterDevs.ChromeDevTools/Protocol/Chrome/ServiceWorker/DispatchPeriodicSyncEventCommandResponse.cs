using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.DispatchPeriodicSyncEvent)]
	[SupportedBy("Chrome")]
	public class DispatchPeriodicSyncEventCommandResponse
	{
	}
}

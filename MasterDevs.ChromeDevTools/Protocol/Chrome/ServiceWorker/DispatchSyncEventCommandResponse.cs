#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.DispatchSyncEvent)]
	[SupportedBy("Chrome")]
	public class DispatchSyncEventCommandResponse
	{
	}
}

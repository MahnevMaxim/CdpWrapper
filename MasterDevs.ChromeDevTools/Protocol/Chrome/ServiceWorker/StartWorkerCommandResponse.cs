using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.StartWorker)]
	[SupportedBy("Chrome")]
	public class StartWorkerCommandResponse
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.StopAllWorkers)]
	[SupportedBy("Chrome")]
	public class StopAllWorkersCommand: ICommand<StopAllWorkersCommandResponse>
	{
	}
}

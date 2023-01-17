using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	[Command(ProtocolName.Memory.GetDOMCounters)]
	[SupportedBy("Chrome")]
	public class GetDOMCountersCommand: ICommand<GetDOMCountersCommandResponse>
	{
	}
}

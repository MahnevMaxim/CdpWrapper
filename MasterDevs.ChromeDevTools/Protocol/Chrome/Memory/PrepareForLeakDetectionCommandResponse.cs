using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	[CommandResponse(ProtocolName.Memory.PrepareForLeakDetection)]
	[SupportedBy("Chrome")]
	public class PrepareForLeakDetectionCommandResponse
	{
	}
}

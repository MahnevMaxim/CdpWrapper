using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	[CommandResponse(ProtocolName.Runtime.SetMaxCallStackSizeToCapture)]
	[SupportedBy("Chrome")]
	public class SetMaxCallStackSizeToCaptureCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	[Obsolete]
	[CommandResponse(ProtocolName.Debugger.PauseOnAsyncCall)]
	[SupportedBy("Chrome")]
	public class PauseOnAsyncCallCommandResponse
	{
	}
}

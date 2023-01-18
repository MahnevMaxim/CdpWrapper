#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	[CommandResponse(ProtocolName.Emulation.SetScrollbarsHidden)]
	[SupportedBy("Chrome")]
	public class SetScrollbarsHiddenCommandResponse
	{
	}
}

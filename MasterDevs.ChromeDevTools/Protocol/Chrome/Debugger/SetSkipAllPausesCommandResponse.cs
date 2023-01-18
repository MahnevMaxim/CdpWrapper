#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Makes page not interrupt on any pauses (breakpoint, exception, dom exception etc).
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetSkipAllPauses)]
	[SupportedBy("Chrome")]
	public class SetSkipAllPausesCommandResponse
	{
	}
}

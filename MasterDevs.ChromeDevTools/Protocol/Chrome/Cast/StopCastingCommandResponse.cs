#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Stops the active Cast session on the sink.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.StopCasting)]
	[SupportedBy("Chrome")]
	public class StopCastingCommandResponse
	{
	}
}

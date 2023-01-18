#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>
	[CommandResponse(ProtocolName.Tracing.End)]
	[SupportedBy("Chrome")]
	public class EndCommandResponse
	{
	}
}

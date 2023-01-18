#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Start collecting native memory profile.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.StartSampling)]
	[SupportedBy("Chrome")]
	public class StartSamplingCommandResponse
	{
	}
}

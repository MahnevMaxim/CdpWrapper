#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Enables CPU throttling to emulate slow CPUs.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetCPUThrottlingRate)]
	[SupportedBy("Chrome")]
	public class SetCPUThrottlingRateCommandResponse
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Simulate a memory pressure notification in all processes.
	/// </summary>
	[CommandResponse(ProtocolName.Memory.SimulatePressureNotification)]
	[SupportedBy("Chrome")]
	public class SimulatePressureNotificationCommandResponse
	{
	}
}

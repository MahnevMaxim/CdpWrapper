using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Notification sent after the virtual time budget for the current VirtualTimePolicy has run out.
	/// </summary>
	[Event(ProtocolName.Emulation.VirtualTimeBudgetExpired)]
	[SupportedBy("Chrome")]
	public class VirtualTimeBudgetExpiredEvent
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Fired when the virtual machine resumed execution.
	/// </summary>
	[Event(ProtocolName.Debugger.Resumed)]
	[SupportedBy("Chrome")]
	public class ResumedEvent
	{
	}
}

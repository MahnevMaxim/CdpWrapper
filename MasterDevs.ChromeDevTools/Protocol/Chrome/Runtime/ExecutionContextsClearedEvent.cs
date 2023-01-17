using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when all executionContexts were cleared in browser
	/// </summary>
	[Event(ProtocolName.Runtime.ExecutionContextsCleared)]
	[SupportedBy("Chrome")]
	public class ExecutionContextsClearedEvent
	{
	}
}

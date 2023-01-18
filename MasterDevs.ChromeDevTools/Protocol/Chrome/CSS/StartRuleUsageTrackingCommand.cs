#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Enables the selector recording.
	/// </summary>
	[Command(ProtocolName.CSS.StartRuleUsageTracking)]
	[SupportedBy("Chrome")]
	public class StartRuleUsageTrackingCommand: ICommand<StartRuleUsageTrackingCommandResponse>
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Disables event updates for the service.
	/// </summary>
	[CommandResponse(ProtocolName.BackgroundService.StopObserving)]
	[SupportedBy("Chrome")]
	public class StopObservingCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Controls whether page will emit lifecycle events.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetLifecycleEventsEnabled)]
	[SupportedBy("Chrome")]
	public class SetLifecycleEventsEnabledCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Enables target discovery for the specified locations, when `setDiscoverTargets` was set to `true`.
	/// </summary>
	[CommandResponse(ProtocolName.Target.SetRemoteLocations)]
	[SupportedBy("Chrome")]
	public class SetRemoteLocationsCommandResponse
	{
	}
}

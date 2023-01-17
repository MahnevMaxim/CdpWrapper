using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Enables/Disables issuing of interestGroupAccessed events.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.SetInterestGroupTracking)]
	[SupportedBy("Chrome")]
	public class SetInterestGroupTrackingCommandResponse
	{
	}
}

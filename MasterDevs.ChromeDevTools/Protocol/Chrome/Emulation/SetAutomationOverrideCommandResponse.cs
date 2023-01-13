using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Allows overriding the automation flag.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetAutomationOverride)]
	[SupportedBy("Chrome")]
	public class SetAutomationOverrideCommandResponse
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Clears Idle state overrides.
	/// </summary>
	[Command(ProtocolName.Emulation.ClearIdleOverride)]
	[SupportedBy("Chrome")]
	public class ClearIdleOverrideCommand: ICommand<ClearIdleOverrideCommandResponse>
	{
	}
}

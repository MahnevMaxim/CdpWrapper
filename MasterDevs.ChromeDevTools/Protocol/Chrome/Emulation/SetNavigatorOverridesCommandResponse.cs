#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides value returned by the javascript navigator object.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Emulation.SetNavigatorOverrides)]
	[SupportedBy("Chrome")]
	public class SetNavigatorOverridesCommandResponse
	{
	}
}

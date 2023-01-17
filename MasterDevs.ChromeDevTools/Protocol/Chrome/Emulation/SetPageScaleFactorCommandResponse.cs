using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Sets a specified page scale factor.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetPageScaleFactor)]
	[SupportedBy("Chrome")]
	public class SetPageScaleFactorCommandResponse
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Activates (focuses) the target.
	/// </summary>
	[CommandResponse(ProtocolName.Target.ActivateTarget)]
	[SupportedBy("Chrome")]
	public class ActivateTargetCommandResponse
	{
	}
}

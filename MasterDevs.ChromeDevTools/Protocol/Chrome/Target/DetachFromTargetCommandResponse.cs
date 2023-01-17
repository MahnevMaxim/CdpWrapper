using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Detaches session with given id.
	/// </summary>
	[CommandResponse(ProtocolName.Target.DetachFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachFromTargetCommandResponse
	{
	}
}

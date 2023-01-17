using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Attaches to the browser target, only uses flat sessionId mode.
	/// </summary>
	[Command(ProtocolName.Target.AttachToBrowserTarget)]
	[SupportedBy("Chrome")]
	public class AttachToBrowserTargetCommand: ICommand<AttachToBrowserTargetCommandResponse>
	{
	}
}

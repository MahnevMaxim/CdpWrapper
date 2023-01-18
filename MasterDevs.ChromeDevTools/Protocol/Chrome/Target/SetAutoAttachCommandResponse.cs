#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Controls whether to automatically attach to new targets which are considered to be related to this one. When turned on, attaches to all existing related targets as well. When turned off, automatically detaches from all currently attached targets. This also clears all targets added by `autoAttachRelated` from the list of targets to watch for creation of related targets.
	/// </summary>
	[CommandResponse(ProtocolName.Target.SetAutoAttach)]
	[SupportedBy("Chrome")]
	public class SetAutoAttachCommandResponse
	{
	}
}

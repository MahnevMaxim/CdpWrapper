using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Starts mirroring the desktop to the sink.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.StartDesktopMirroring)]
	[SupportedBy("Chrome")]
	public class StartDesktopMirroringCommandResponse
	{
	}
}

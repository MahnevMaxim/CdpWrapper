#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Cast
{
	/// <summary>
	/// Sets a sink to be used when the web page requests the browser to choose a sink via Presentation API, Remote Playback API, or Cast SDK.
	/// </summary>
	[CommandResponse(ProtocolName.Cast.SetSinkToUse)]
	[SupportedBy("Chrome")]
	public class SetSinkToUseCommandResponse
	{
	}
}

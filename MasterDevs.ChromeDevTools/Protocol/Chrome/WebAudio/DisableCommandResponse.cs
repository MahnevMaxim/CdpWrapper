using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Disables the WebAudio domain.
	/// </summary>
	[CommandResponse(ProtocolName.WebAudio.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Disable the WebAuthn domain.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

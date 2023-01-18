#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Enable the WebAuthn domain and start intercepting credential storage and retrieval with a virtual authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

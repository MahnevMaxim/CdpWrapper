#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes the given authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.RemoveVirtualAuthenticator)]
	[SupportedBy("Chrome")]
	public class RemoveVirtualAuthenticatorCommandResponse
	{
	}
}

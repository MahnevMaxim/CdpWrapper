using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Removes a credential from the authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.RemoveCredential)]
	[SupportedBy("Chrome")]
	public class RemoveCredentialCommandResponse
	{
	}
}

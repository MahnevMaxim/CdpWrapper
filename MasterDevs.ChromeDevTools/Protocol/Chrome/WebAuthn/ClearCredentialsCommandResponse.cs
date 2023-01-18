#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Clears all the credentials from the specified device.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.ClearCredentials)]
	[SupportedBy("Chrome")]
	public class ClearCredentialsCommandResponse
	{
	}
}

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
	[Command(ProtocolName.WebAuthn.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommand: ICommand<DisableCommandResponse>
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAuthn
{
	/// <summary>
	/// Creates and adds a virtual authenticator.
	/// </summary>
	[CommandResponse(ProtocolName.WebAuthn.AddVirtualAuthenticator)]
	[SupportedBy("Chrome")]
	public class AddVirtualAuthenticatorCommandResponse
	{
		/// <summary>
		/// Gets or sets AuthenticatorId
		/// </summary>
		public string AuthenticatorId { get; set; }
	}
}

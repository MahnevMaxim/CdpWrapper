#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[Obsolete]
	[CommandResponse(ProtocolName.Network.CanEmulateNetworkConditions)]
	[SupportedBy("Chrome")]
	public class CanEmulateNetworkConditionsCommandResponse
	{
		/// <summary>
		/// Gets or sets True if emulation of network conditions is supported.
		/// </summary>
		public bool Result { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns information about the COEP/COOP isolation status.
	/// </summary>
	[CommandResponse(ProtocolName.Network.GetSecurityIsolationStatus)]
	[SupportedBy("Chrome")]
	public class GetSecurityIsolationStatusCommandResponse
	{
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		public SecurityIsolationStatus Status { get; set; }
	}
}

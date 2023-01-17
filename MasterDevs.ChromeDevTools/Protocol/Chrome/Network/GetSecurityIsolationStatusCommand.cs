using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Returns information about the COEP/COOP isolation status.
	/// </summary>
	[Command(ProtocolName.Network.GetSecurityIsolationStatus)]
	[SupportedBy("Chrome")]
	public class GetSecurityIsolationStatusCommand: ICommand<GetSecurityIsolationStatusCommandResponse>
	{
		/// <summary>
		/// Gets or sets If no frameId is provided, the status of the target is provided.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}

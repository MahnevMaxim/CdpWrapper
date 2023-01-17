using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	/// Causes the request to fail with specified reason.
	/// </summary>
	[Command(ProtocolName.Fetch.FailRequest)]
	[SupportedBy("Chrome")]
	public class FailRequestCommand: ICommand<FailRequestCommandResponse>
	{
		/// <summary>
		/// Gets or sets An id the client received in requestPaused event.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Causes the request to fail with the given reason.
		/// </summary>
		public string ErrorReason { get; set; }
	}
}

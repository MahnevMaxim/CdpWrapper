using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Invoke custom browser commands used by telemetry.
	/// </summary>
	[Command(ProtocolName.Browser.ExecuteBrowserCommand)]
	[SupportedBy("Chrome")]
	public class ExecuteBrowserCommandCommand: ICommand<ExecuteBrowserCommandCommandResponse>
	{
		/// <summary>
		/// Gets or sets CommandId
		/// </summary>
		public string CommandId { get; set; }
	}
}

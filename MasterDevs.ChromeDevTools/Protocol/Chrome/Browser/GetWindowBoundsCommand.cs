using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Get position and size of the browser window.
	/// </summary>
	[Command(ProtocolName.Browser.GetWindowBounds)]
	[SupportedBy("Chrome")]
	public class GetWindowBoundsCommand: ICommand<GetWindowBoundsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Browser window id.
		/// </summary>
		public long WindowId { get; set; }
	}
}

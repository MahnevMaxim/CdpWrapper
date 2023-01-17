using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	[Command(ProtocolName.Overlay.SetPausedInDebuggerMessage)]
	[SupportedBy("Chrome")]
	public class SetPausedInDebuggerMessageCommand: ICommand<SetPausedInDebuggerMessageCommandResponse>
	{
		/// <summary>
		/// Gets or sets The message to display, also triggers resume and step over controls.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Message { get; set; }
	}
}

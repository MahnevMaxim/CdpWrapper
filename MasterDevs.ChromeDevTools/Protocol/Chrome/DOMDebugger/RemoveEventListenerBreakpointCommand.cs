#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveEventListenerBreakpointCommand: ICommand<RemoveEventListenerBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Event name.
		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets EventTarget interface name.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetName { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Fired when breakpoint is resolved to an actual script and location.
	/// </summary>
	[Event(ProtocolName.Debugger.BreakpointResolved)]
	[SupportedBy("Chrome")]
	public class BreakpointResolvedEvent
	{
		/// <summary>
		/// Gets or sets Breakpoint unique identifier.
		/// </summary>
		public string BreakpointId { get; set; }
		/// <summary>
		/// Gets or sets Actual breakpoint location.
		/// </summary>
		public Location Location { get; set; }
	}
}

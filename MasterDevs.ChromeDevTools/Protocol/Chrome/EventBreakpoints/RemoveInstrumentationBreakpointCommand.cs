using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.EventBreakpoints
{
	/// <summary>
	/// Removes breakpoint on particular native event.
	/// </summary>
	[Command(ProtocolName.EventBreakpoints.RemoveInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveInstrumentationBreakpointCommand: ICommand<RemoveInstrumentationBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}

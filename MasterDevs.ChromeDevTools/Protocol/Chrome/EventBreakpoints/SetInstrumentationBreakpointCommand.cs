using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.EventBreakpoints
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[Command(ProtocolName.EventBreakpoints.SetInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommand: ICommand<SetInstrumentationBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets Instrumentation name to stop on.
		/// </summary>
		public string EventName { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Restarts particular call frame from the beginning. The old, deprecated behavior of `restartFrame` is to stay paused and allow further CDP commands after a restart was scheduled. This can cause problems with restarting, so we now continue execution immediatly after it has been scheduled until we reach the beginning of the restarted frame.  To stay back-wards compatible, `restartFrame` now expects a `mode` parameter to be present. If the `mode` parameter is missing, `restartFrame` errors out.  The various return values are deprecated and `callFrames` is always empty. Use the call frames from the `Debugger#paused` events instead, that fires once V8 pauses at the beginning of the restarted function.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RestartFrame)]
	[SupportedBy("Chrome")]
	public class RestartFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets New stack trace.
		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace AsyncStackTrace { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTraceId AsyncStackTraceId { get; set; }
	}
}

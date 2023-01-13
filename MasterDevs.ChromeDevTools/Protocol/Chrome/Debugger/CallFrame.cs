using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// JavaScript call frame. Array of call frames form the call stack.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CallFrame
	{
		/// <summary>
		/// Gets or sets Call frame identifier. This identifier is only valid while the virtual machine is paused.
		/// </summary>
		public string CallFrameId { get; set; }
		/// <summary>
		/// Gets or sets Name of the JavaScript function called on this call frame.
		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Location in the source code.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location FunctionLocation { get; set; }
		/// <summary>
		/// Gets or sets Location in the source code.
		/// </summary>
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets JavaScript script name or url. Deprecated in favor of using the `location.scriptId` to resolve the URL via a previously sent `Debugger.scriptParsed` event.
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Scope chain for this call frame.
		/// </summary>
		public Scope[] ScopeChain { get; set; }
		/// <summary>
		/// Gets or sets `this` object for this call frame.
		/// </summary>
		public Runtime.RemoteObject This { get; set; }
		/// <summary>
		/// Gets or sets The value being returned, if the function is at return point.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject ReturnValue { get; set; }
		/// <summary>
		/// Gets or sets Valid only while the VM is paused and indicates whether this frame can be restarted or not. Note that a `true` value here does not guarantee that Debugger#restartFrame with this CallFrameId will be successful, but it is very likely.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CanBeRestarted { get; set; }
	}
}

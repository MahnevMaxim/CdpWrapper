#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Issued when detached from target for any reason (including `detachFromTarget` command). Can be issued multiple times per target if multiple sessions have been attached to it.
	/// </summary>
	[Event(ProtocolName.Target.DetachedFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachedFromTargetEvent
	{
		/// <summary>
		/// Gets or sets Detached session identifier.
		/// </summary>
		public string SessionId { get; set; }
		/// <summary>
		/// Gets or sets Deprecated.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}

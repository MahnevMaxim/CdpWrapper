#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Issued when a possible inspection target is created.
	/// </summary>
	[Event(ProtocolName.Target.TargetCreated)]
	[SupportedBy("Chrome")]
	public class TargetCreatedEvent
	{
		/// <summary>
		/// Gets or sets TargetInfo
		/// </summary>
		public TargetInfo TargetInfo { get; set; }
	}
}

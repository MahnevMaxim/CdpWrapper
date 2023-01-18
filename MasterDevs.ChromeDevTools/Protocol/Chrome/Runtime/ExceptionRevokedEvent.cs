#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Issued when unhandled exception was revoked.
	/// </summary>
	[Event(ProtocolName.Runtime.ExceptionRevoked)]
	[SupportedBy("Chrome")]
	public class ExceptionRevokedEvent
	{
		/// <summary>
		/// Gets or sets Reason describing why exception was revoked.
		/// </summary>
		public string Reason { get; set; }
		/// <summary>
		/// Gets or sets The id of revoked exception, as reported in `exceptionThrown`.
		/// </summary>
		public long ExceptionId { get; set; }
	}
}

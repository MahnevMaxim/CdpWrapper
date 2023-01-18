#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	/// Information about the frame affected by an inspector issue.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AffectedFrame
	{
		/// <summary>
		/// Gets or sets FrameId
		/// </summary>
		public string FrameId { get; set; }
	}
}

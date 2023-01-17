using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// One of the interest groups was accessed by the associated page.
	/// </summary>
	[Event(ProtocolName.Storage.InterestGroupAccessed)]
	[SupportedBy("Chrome")]
	public class InterestGroupAccessedEvent
	{
		/// <summary>
		/// Gets or sets AccessTime
		/// </summary>
		public double AccessTime { get; set; }
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public InterestGroupAccessType Type { get; set; }
		/// <summary>
		/// Gets or sets OwnerOrigin
		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Gets or sets Name
		/// </summary>
		public string Name { get; set; }
	}
}

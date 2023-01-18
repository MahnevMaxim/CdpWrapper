#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Fired when HTTP response is available.
	/// </summary>
	[Event(ProtocolName.Network.ResponseReceived)]
	[SupportedBy("Chrome")]
	public class ResponseReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier. Empty string if the request is fetched from worker.
		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Resource type.
		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Response data.
		/// </summary>
		public Response Response { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be or were emitted for this request.
		/// </summary>
		public bool HasExtraInfo { get; set; }
		/// <summary>
		/// Gets or sets Frame identifier.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}

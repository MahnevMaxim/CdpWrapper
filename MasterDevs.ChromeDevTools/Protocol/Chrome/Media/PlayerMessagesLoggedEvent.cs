#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// Send a list of any messages that need to be delivered.
	/// </summary>
	[Event(ProtocolName.Media.PlayerMessagesLogged)]
	[SupportedBy("Chrome")]
	public class PlayerMessagesLoggedEvent
	{
		/// <summary>
		/// Gets or sets PlayerId
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Gets or sets Messages
		/// </summary>
		public PlayerMessage[] Messages { get; set; }
	}
}

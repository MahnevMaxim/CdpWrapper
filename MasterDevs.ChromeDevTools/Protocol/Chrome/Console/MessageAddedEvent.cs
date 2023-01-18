#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Issued when new console message is added.
	/// </summary>
	[Event(ProtocolName.Console.MessageAdded)]
	[SupportedBy("Chrome")]
	public class MessageAddedEvent
	{
		/// <summary>
		/// Gets or sets Console message that has been added.
		/// </summary>
		public ConsoleMessage Message { get; set; }
	}
}

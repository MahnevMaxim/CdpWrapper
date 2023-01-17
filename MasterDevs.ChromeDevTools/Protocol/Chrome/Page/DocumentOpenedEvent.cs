using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when opening document to write to.
	/// </summary>
	[Event(ProtocolName.Page.DocumentOpened)]
	[SupportedBy("Chrome")]
	public class DocumentOpenedEvent
	{
		/// <summary>
		/// Gets or sets Frame object.
		/// </summary>
		public Frame Frame { get; set; }
	}
}

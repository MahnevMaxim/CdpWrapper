using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Ignores input events (useful while auditing page).
	/// </summary>
	[Command(ProtocolName.Input.SetIgnoreInputEvents)]
	[SupportedBy("Chrome")]
	public class SetIgnoreInputEventsCommand: ICommand<SetIgnoreInputEventsCommandResponse>
	{
		/// <summary>
		/// Gets or sets Ignores input events processing when set to true.
		/// </summary>
		public bool Ignore { get; set; }
	}
}

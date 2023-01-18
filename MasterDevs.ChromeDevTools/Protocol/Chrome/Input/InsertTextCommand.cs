#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// This method emulates inserting text that doesn't come from a key press, for example an emoji keyboard or an IME.
	/// </summary>
	[Command(ProtocolName.Input.InsertText)]
	[SupportedBy("Chrome")]
	public class InsertTextCommand: ICommand<InsertTextCommandResponse>
	{
		/// <summary>
		/// Gets or sets The text to insert.
		/// </summary>
		public string Text { get; set; }
	}
}

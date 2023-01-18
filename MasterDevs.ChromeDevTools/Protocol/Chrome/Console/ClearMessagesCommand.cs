#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Console
{
	/// <summary>
	/// Does nothing.
	/// </summary>
	[Command(ProtocolName.Console.ClearMessages)]
	[SupportedBy("Chrome")]
	public class ClearMessagesCommand: ICommand<ClearMessagesCommandResponse>
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Undoes the last performed action.
	/// </summary>
	[Command(ProtocolName.DOM.Undo)]
	[SupportedBy("Chrome")]
	public class UndoCommand: ICommand<UndoCommandResponse>
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Re-does the last undone action.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Redo)]
	[SupportedBy("Chrome")]
	public class RedoCommandResponse
	{
	}
}

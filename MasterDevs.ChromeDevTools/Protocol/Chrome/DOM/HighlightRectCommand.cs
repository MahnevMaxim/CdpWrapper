#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Highlights given rectangle.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightRect)]
	[SupportedBy("Chrome")]
	public class HighlightRectCommand: ICommand<HighlightRectCommandResponse>
	{
	}
}

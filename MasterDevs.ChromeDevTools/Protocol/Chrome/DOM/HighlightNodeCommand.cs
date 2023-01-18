#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Highlights DOM node.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightNode)]
	[SupportedBy("Chrome")]
	public class HighlightNodeCommand: ICommand<HighlightNodeCommandResponse>
	{
	}
}

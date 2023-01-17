using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.Focus)]
	[SupportedBy("Chrome")]
	public class FocusCommandResponse
	{
	}
}

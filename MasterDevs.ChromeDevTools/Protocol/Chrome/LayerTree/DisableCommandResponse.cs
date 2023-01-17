using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Disables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

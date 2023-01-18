#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Enables compositing tree inspection.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}

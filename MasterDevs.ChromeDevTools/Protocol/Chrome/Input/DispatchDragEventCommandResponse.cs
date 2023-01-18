#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Dispatches a drag event into the page.
	/// </summary>
	[CommandResponse(ProtocolName.Input.DispatchDragEvent)]
	[SupportedBy("Chrome")]
	public class DispatchDragEventCommandResponse
	{
	}
}

using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Show elements in isolation mode with overlays.
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowIsolatedElements)]
	[SupportedBy("Chrome")]
	public class SetShowIsolatedElementsCommandResponse
	{
	}
}

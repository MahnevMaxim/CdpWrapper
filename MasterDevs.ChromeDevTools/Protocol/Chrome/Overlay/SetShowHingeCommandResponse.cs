using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Add a dual screen device hinge
	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowHinge)]
	[SupportedBy("Chrome")]
	public class SetShowHingeCommandResponse
	{
	}
}

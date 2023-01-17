using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.ForcePseudoState)]
	[SupportedBy("Chrome")]
	public class ForcePseudoStateCommandResponse
	{
	}
}

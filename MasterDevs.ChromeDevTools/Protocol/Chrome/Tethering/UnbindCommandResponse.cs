using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Request browser port unbinding.
	/// </summary>
	[CommandResponse(ProtocolName.Tethering.Unbind)]
	[SupportedBy("Chrome")]
	public class UnbindCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tethering
{
	/// <summary>
	/// Request browser port binding.
	/// </summary>
	[CommandResponse(ProtocolName.Tethering.Bind)]
	[SupportedBy("Chrome")]
	public class BindCommandResponse
	{
	}
}

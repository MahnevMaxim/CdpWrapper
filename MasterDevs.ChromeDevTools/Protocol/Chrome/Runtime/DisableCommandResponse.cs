#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

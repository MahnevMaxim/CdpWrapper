#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// Disables the accessibility domain.
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}

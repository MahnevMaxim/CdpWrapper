#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	[CommandResponse(ProtocolName.Emulation.SetDocumentCookieDisabled)]
	[SupportedBy("Chrome")]
	public class SetDocumentCookieDisabledCommandResponse
	{
	}
}

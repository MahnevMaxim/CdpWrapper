#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetAcceptedEncodings)]
	[SupportedBy("Chrome")]
	public class SetAcceptedEncodingsCommandResponse
	{
	}
}

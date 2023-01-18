#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Changes return value in top frame. Available only at return break position.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetReturnValue)]
	[SupportedBy("Chrome")]
	public class SetReturnValueCommandResponse
	{
	}
}

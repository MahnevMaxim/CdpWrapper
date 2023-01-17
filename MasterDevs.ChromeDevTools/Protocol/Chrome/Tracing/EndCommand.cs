using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.End)]
	[SupportedBy("Chrome")]
	public class EndCommand: ICommand<EndCommandResponse>
	{
	}
}

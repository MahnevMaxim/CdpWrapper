#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Retrieves a list of available targets.
	/// </summary>
	[Command(ProtocolName.Target.GetTargets)]
	[SupportedBy("Chrome")]
	public class GetTargetsCommand: ICommand<GetTargetsCommandResponse>
	{
	}
}

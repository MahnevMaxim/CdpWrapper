using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Steps out of the function call.
	/// </summary>
	[Command(ProtocolName.Debugger.StepOut)]
	[SupportedBy("Chrome")]
	public class StepOutCommand: ICommand<StepOutCommandResponse>
	{
	}
}

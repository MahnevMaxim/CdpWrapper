using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Obtain list of rules that became used since last call to this method (or since start of coverage instrumentation)
	/// </summary>
	[Command(ProtocolName.CSS.TakeCoverageDelta)]
	[SupportedBy("Chrome")]
	public class TakeCoverageDeltaCommand: ICommand<TakeCoverageDeltaCommandResponse>
	{
	}
}

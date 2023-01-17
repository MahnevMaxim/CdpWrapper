using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate, and resets execution counters. Precise code coverage needs to have started.
	/// </summary>
	[Command(ProtocolName.Profiler.TakePreciseCoverage)]
	[SupportedBy("Chrome")]
	public class TakePreciseCoverageCommand: ICommand<TakePreciseCoverageCommandResponse>
	{
	}
}

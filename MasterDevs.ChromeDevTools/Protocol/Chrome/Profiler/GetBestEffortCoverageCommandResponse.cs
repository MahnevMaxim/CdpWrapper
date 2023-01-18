#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collect coverage data for the current isolate. The coverage data may be incomplete due to garbage collection.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.GetBestEffortCoverage)]
	[SupportedBy("Chrome")]
	public class GetBestEffortCoverageCommandResponse
	{
		/// <summary>
		/// Gets or sets Coverage data for the current isolate.
		/// </summary>
		public ScriptCoverage[] Result { get; set; }
	}
}

using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Requests backend to produce compilation cache for the specified scripts. `scripts` are appeneded to the list of scripts for which the cache would be produced. The list may be reset during page navigation. When script with a matching URL is encountered, the cache is optionally produced upon backend discretion, based on internal heuristics. See also: `Page.compilationCacheProduced`.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ProduceCompilationCache)]
	[SupportedBy("Chrome")]
	public class ProduceCompilationCacheCommandResponse
	{
	}
}

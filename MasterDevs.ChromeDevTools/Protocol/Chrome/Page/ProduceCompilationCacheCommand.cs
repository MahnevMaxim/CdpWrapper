using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Requests backend to produce compilation cache for the specified scripts. `scripts` are appeneded to the list of scripts for which the cache would be produced. The list may be reset during page navigation. When script with a matching URL is encountered, the cache is optionally produced upon backend discretion, based on internal heuristics. See also: `Page.compilationCacheProduced`.
	/// </summary>
	[Command(ProtocolName.Page.ProduceCompilationCache)]
	[SupportedBy("Chrome")]
	public class ProduceCompilationCacheCommand: ICommand<ProduceCompilationCacheCommandResponse>
	{
		/// <summary>
		/// Gets or sets Scripts
		/// </summary>
		public CompilationCacheParams[] Scripts { get; set; }
	}
}

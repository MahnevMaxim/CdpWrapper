using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Clears seeded compilation cache.
	/// </summary>
	[Command(ProtocolName.Page.ClearCompilationCache)]
	[SupportedBy("Chrome")]
	public class ClearCompilationCacheCommand: ICommand<ClearCompilationCacheCommandResponse>
	{
	}
}

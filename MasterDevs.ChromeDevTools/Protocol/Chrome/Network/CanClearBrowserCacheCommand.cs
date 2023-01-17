using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.CanClearBrowserCache)]
	[SupportedBy("Chrome")]
	public class CanClearBrowserCacheCommand: ICommand<CanClearBrowserCacheCommandResponse>
	{
	}
}

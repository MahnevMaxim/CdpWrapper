#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Returns all browser contexts created with `Target.createBrowserContext` method.
	/// </summary>
	[CommandResponse(ProtocolName.Target.GetBrowserContexts)]
	[SupportedBy("Chrome")]
	public class GetBrowserContextsCommandResponse
	{
		/// <summary>
		/// Gets or sets An array of browser context ids.
		/// </summary>
		public string[] BrowserContextIds { get; set; }
	}
}

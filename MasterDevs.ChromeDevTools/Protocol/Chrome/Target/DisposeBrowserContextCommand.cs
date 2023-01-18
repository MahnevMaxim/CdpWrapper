#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Deletes a BrowserContext. All the belonging pages will be closed without calling their beforeunload hooks.
	/// </summary>
	[Command(ProtocolName.Target.DisposeBrowserContext)]
	[SupportedBy("Chrome")]
	public class DisposeBrowserContextCommand: ICommand<DisposeBrowserContextCommandResponse>
	{
		/// <summary>
		/// Gets or sets BrowserContextId
		/// </summary>
		public string BrowserContextId { get; set; }
	}
}

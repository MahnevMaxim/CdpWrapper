#pragma warning disable
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
	[CommandResponse(ProtocolName.Network.CanClearBrowserCache)]
	[SupportedBy("Chrome")]
	public class CanClearBrowserCacheCommandResponse
	{
		/// <summary>
		/// Gets or sets True if browser cache can be cleared.
		/// </summary>
		public bool Result { get; set; }
	}
}

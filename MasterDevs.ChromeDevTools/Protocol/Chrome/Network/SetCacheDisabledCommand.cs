#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If `true`, cache will not be used.
	/// </summary>
	[Command(ProtocolName.Network.SetCacheDisabled)]
	[SupportedBy("Chrome")]
	public class SetCacheDisabledCommand: ICommand<SetCacheDisabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Cache disabled state.
		/// </summary>
		public bool CacheDisabled { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Sets the requests to intercept that match the provided patterns and optionally resource types. Deprecated, please use Fetch.enable instead.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.SetRequestInterception)]
	[SupportedBy("Chrome")]
	public class SetRequestInterceptionCommand: ICommand<SetRequestInterceptionCommandResponse>
	{
		/// <summary>
		/// Gets or sets Requests matching any of these patterns will be forwarded and wait for the corresponding continueInterceptedRequest call.
		/// </summary>
		public RequestPattern[] Patterns { get; set; }
	}
}

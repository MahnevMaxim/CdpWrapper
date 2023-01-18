#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Sets given cookies.
	/// </summary>
	[Command(ProtocolName.Storage.SetCookies)]
	[SupportedBy("Chrome")]
	public class SetCookiesCommand: ICommand<SetCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Cookies to be set.
		/// </summary>
		public Network.CookieParam[] Cookies { get; set; }
		/// <summary>
		/// Gets or sets Browser context to use when called on the browser endpoint.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BrowserContextId { get; set; }
	}
}

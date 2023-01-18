#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	[SupportedBy("Chrome")]
	public class RemoteLocation
	{
		/// <summary>
		/// Gets or sets Host
		/// </summary>
		public string Host { get; set; }
		/// <summary>
		/// Gets or sets Port
		/// </summary>
		public long Port { get; set; }
	}
}

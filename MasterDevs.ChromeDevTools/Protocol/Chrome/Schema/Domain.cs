#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Schema
{
	/// <summary>
	/// Description of the protocol domain.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Domain
	{
		/// <summary>
		/// Gets or sets Domain name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Domain version.
		/// </summary>
		public string Version { get; set; }
	}
}

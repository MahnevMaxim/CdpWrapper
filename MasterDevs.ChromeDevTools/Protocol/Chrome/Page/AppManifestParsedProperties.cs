using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Parsed app manifest properties.
	/// </summary>
	[SupportedBy("Chrome")]
	public class AppManifestParsedProperties
	{
		/// <summary>
		/// Gets or sets Computed scope value
		/// </summary>
		public string Scope { get; set; }
	}
}

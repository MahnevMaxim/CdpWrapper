#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Represents the value serialiazed by the WebDriver BiDi specification https://w3c.github.io/webdriver-bidi.
	/// </summary>
	[SupportedBy("Chrome")]
	public class WebDriverValue
	{
		/// <summary>
		/// Gets or sets Type
		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Value
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets ObjectId
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}

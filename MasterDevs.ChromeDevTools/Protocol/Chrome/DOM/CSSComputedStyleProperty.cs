#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	[SupportedBy("Chrome")]
	public class CSSComputedStyleProperty
	{
		/// <summary>
		/// Gets or sets Computed style property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Computed style property value.
		/// </summary>
		public string Value { get; set; }
	}
}

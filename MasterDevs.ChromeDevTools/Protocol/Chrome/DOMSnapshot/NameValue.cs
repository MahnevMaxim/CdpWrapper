#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMSnapshot
{
	/// <summary>
	/// A name/value pair.
	/// </summary>
	[SupportedBy("Chrome")]
	public class NameValue
	{
		/// <summary>
		/// Gets or sets Attribute/property name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Attribute/property value.
		/// </summary>
		public string Value { get; set; }
	}
}

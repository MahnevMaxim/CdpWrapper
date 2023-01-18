#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// CSS Supports at-rule descriptor.
	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSSupports
	{
		/// <summary>
		/// Gets or sets Supports rule text.
		/// </summary>
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets Whether the supports condition is satisfied.
		/// </summary>
		public bool Active { get; set; }
		/// <summary>
		/// Gets or sets The associated rule header range in the enclosing stylesheet (if available).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the stylesheet containing this object (if exists).
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
	}
}

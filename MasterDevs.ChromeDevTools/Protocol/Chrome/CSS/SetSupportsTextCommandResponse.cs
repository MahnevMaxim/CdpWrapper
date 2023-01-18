#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a supports at-rule.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetSupportsText)]
	[SupportedBy("Chrome")]
	public class SetSupportsTextCommandResponse
	{
		/// <summary>
		/// Gets or sets The resulting CSS Supports rule after modification.
		/// </summary>
		public CSSSupports Supports { get; set; }
	}
}

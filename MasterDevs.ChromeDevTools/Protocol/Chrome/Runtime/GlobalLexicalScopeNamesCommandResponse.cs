#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns all let, const and class variables from global scope.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GlobalLexicalScopeNames)]
	[SupportedBy("Chrome")]
	public class GlobalLexicalScopeNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Names
		/// </summary>
		public string[] Names { get; set; }
	}
}

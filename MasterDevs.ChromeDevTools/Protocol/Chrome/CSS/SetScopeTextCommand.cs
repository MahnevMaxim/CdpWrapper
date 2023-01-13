using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Modifies the expression of a scope at-rule.
	/// </summary>
	[Command(ProtocolName.CSS.SetScopeText)]
	[SupportedBy("Chrome")]
	public class SetScopeTextCommand: ICommand<SetScopeTextCommandResponse>
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets Range
		/// </summary>
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or sets Text
		/// </summary>
		public string Text { get; set; }
	}
}

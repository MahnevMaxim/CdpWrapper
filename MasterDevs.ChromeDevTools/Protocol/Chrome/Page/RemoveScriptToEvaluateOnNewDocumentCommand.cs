using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Removes given script from the list.
	/// </summary>
	[Command(ProtocolName.Page.RemoveScriptToEvaluateOnNewDocument)]
	[SupportedBy("Chrome")]
	public class RemoveScriptToEvaluateOnNewDocumentCommand: ICommand<RemoveScriptToEvaluateOnNewDocumentCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier
		/// </summary>
		public string Identifier { get; set; }
	}
}

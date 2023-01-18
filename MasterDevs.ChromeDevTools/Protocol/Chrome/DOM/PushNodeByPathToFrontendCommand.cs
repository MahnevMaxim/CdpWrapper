#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its path. // FIXME, use XPath
	/// </summary>
	[Command(ProtocolName.DOM.PushNodeByPathToFrontend)]
	[SupportedBy("Chrome")]
	public class PushNodeByPathToFrontendCommand: ICommand<PushNodeByPathToFrontendCommandResponse>
	{
		/// <summary>
		/// Gets or sets Path to node in the proprietary format.
		/// </summary>
		public string Path { get; set; }
	}
}

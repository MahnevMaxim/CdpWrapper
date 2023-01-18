#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns file information for the given File wrapper.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetFileInfo)]
	[SupportedBy("Chrome")]
	public class GetFileInfoCommandResponse
	{
		/// <summary>
		/// Gets or sets Path
		/// </summary>
		public string Path { get; set; }
	}
}

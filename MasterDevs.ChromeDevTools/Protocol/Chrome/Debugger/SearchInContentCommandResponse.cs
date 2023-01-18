#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SearchInContent)]
	[SupportedBy("Chrome")]
	public class SearchInContentCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		public SearchMatch[] Result { get; set; }
	}
}

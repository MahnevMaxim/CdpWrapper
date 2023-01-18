#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns search results from given `fromIndex` to given `toIndex` from the search with the given identifier.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetSearchResults)]
	[SupportedBy("Chrome")]
	public class GetSearchResultsCommandResponse
	{
		/// <summary>
		/// Gets or sets Ids of the search result nodes.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}

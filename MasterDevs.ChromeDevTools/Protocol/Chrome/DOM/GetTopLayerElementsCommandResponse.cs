using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns NodeIds of current top layer elements. Top layer is rendered closest to the user within a viewport, therefore its elements always appear on top of all other content.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetTopLayerElements)]
	[SupportedBy("Chrome")]
	public class GetTopLayerElementsCommandResponse
	{
		/// <summary>
		/// Gets or sets NodeIds of top layer elements
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}

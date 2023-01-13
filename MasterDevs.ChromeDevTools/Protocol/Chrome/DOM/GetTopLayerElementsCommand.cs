using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Returns NodeIds of current top layer elements. Top layer is rendered closest to the user within a viewport, therefore its elements always appear on top of all other content.
	/// </summary>
	[Command(ProtocolName.DOM.GetTopLayerElements)]
	[SupportedBy("Chrome")]
	public class GetTopLayerElementsCommand: ICommand<GetTopLayerElementsCommandResponse>
	{
	}
}

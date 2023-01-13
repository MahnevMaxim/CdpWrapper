using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Called when top layer elements are changed.
	/// </summary>
	[Event(ProtocolName.DOM.TopLayerElementsUpdated)]
	[SupportedBy("Chrome")]
	public class TopLayerElementsUpdatedEvent
	{
	}
}

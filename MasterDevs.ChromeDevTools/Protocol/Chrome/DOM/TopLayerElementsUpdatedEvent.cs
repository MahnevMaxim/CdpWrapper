#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
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

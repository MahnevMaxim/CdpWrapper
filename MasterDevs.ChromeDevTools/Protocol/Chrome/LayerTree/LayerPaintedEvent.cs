using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.LayerTree
{
	[Event(ProtocolName.LayerTree.LayerPainted)]
	[SupportedBy("Chrome")]
	public class LayerPaintedEvent
	{
		/// <summary>
		/// Gets or sets The id of the painted layer.
		/// </summary>
		public string LayerId { get; set; }
		/// <summary>
		/// Gets or sets Clip rectangle.
		/// </summary>
		public DOM.Rect Clip { get; set; }
	}
}

using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	/// The loadComplete event mirrors the load complete event sent by the browser to assistive technology when the web page has finished loading.
	/// </summary>
	[Event(ProtocolName.Accessibility.LoadComplete)]
	[SupportedBy("Chrome")]
	public class LoadCompleteEvent
	{
		/// <summary>
		/// Gets or sets New document root node.
		/// </summary>
		public AXNode Root { get; set; }
	}
}

using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Returns all layers parsed by the rendering engine for the tree scope of a node. Given a DOM element identified by nodeId, getLayersForNode returns the root layer for the nearest ancestor document or shadow root. The layer root contains the full layer tree for the tree scope and their ordering.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetLayersForNode)]
	[SupportedBy("Chrome")]
	public class GetLayersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets RootLayer
		/// </summary>
		public CSSLayerData RootLayer { get; set; }
	}
}

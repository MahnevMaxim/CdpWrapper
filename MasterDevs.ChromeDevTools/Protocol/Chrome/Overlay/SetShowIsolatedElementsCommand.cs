using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Show elements in isolation mode with overlays.
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowIsolatedElements)]
	[SupportedBy("Chrome")]
	public class SetShowIsolatedElementsCommand: ICommand<SetShowIsolatedElementsCommandResponse>
	{
		/// <summary>
		/// Gets or sets An array of node identifiers and descriptors for the highlight appearance.
		/// </summary>
		public IsolatedElementHighlightConfig[] IsolatedElementHighlightConfigs { get; set; }
	}
}

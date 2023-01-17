using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// For Persistent Grid testing.
	/// </summary>
	[Command(ProtocolName.Overlay.GetGridHighlightObjectsForTest)]
	[SupportedBy("Chrome")]
	public class GetGridHighlightObjectsForTestCommand: ICommand<GetGridHighlightObjectsForTestCommandResponse>
	{
		/// <summary>
		/// Gets or sets Ids of the node to get highlight object for.
		/// </summary>
		public long[] NodeIds { get; set; }
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Paints viewport size upon main frame resize.
	/// </summary>
	[Command(ProtocolName.Overlay.SetShowViewportSizeOnResize)]
	[SupportedBy("Chrome")]
	public class SetShowViewportSizeOnResizeCommand: ICommand<SetShowViewportSizeOnResizeCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether to paint size or not.
		/// </summary>
		public bool Show { get; set; }
	}
}

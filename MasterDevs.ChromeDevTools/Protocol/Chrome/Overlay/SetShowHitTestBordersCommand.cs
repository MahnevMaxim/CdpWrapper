using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Deprecated, no longer has any effect.
	/// </summary>
	[Obsolete("Deprecated, no longer has any effect.")]
	[Command(ProtocolName.Overlay.SetShowHitTestBorders)]
	[SupportedBy("Chrome")]
	public class SetShowHitTestBordersCommand: ICommand<SetShowHitTestBordersCommandResponse>
	{
		/// <summary>
		/// Gets or sets True for showing hit-test borders
		/// </summary>
		public bool Show { get; set; }
	}
}

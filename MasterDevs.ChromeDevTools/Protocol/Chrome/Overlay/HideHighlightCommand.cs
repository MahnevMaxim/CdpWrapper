using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	/// Hides any highlight.
	/// </summary>
	[Command(ProtocolName.Overlay.HideHighlight)]
	[SupportedBy("Chrome")]
	public class HideHighlightCommand: ICommand<HideHighlightCommandResponse>
	{
	}
}

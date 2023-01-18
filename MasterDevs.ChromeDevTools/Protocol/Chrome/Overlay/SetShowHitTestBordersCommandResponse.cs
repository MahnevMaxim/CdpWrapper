#pragma warning disable
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
	[CommandResponse(ProtocolName.Overlay.SetShowHitTestBorders)]
	[SupportedBy("Chrome")]
	public class SetShowHitTestBordersCommandResponse
	{
	}
}

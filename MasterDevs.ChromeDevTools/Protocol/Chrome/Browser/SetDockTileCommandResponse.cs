using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Set dock tile details, platform-specific.
	/// </summary>
	[CommandResponse(ProtocolName.Browser.SetDockTile)]
	[SupportedBy("Chrome")]
	public class SetDockTileCommandResponse
	{
	}
}

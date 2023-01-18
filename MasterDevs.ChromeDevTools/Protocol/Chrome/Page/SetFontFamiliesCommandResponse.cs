#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set generic font families.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetFontFamilies)]
	[SupportedBy("Chrome")]
	public class SetFontFamiliesCommandResponse
	{
	}
}

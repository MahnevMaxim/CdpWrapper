#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Set default font sizes.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetFontSizes)]
	[SupportedBy("Chrome")]
	public class SetFontSizesCommandResponse
	{
	}
}

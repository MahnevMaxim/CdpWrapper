#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Resets navigation history for the current page.
	/// </summary>
	[CommandResponse(ProtocolName.Page.ResetNavigationHistory)]
	[SupportedBy("Chrome")]
	public class ResetNavigationHistoryCommandResponse
	{
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Fired when interstitial page was shown
	/// </summary>
	[Event(ProtocolName.Page.InterstitialShown)]
	[SupportedBy("Chrome")]
	public class InterstitialShownEvent
	{
	}
}

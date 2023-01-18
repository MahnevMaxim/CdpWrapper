#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Close browser gracefully.
	/// </summary>
	[Command(ProtocolName.Browser.Close)]
	[SupportedBy("Chrome")]
	public class CloseCommand: ICommand<CloseCommandResponse>
	{
	}
}

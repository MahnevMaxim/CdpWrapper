using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Crashes browser on the main thread.
	/// </summary>
	[Command(ProtocolName.Browser.Crash)]
	[SupportedBy("Chrome")]
	public class CrashCommand: ICommand<CrashCommandResponse>
	{
	}
}

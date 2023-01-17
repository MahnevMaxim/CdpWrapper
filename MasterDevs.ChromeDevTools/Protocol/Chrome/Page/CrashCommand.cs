using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Crashes renderer on the IO thread, generates minidumps.
	/// </summary>
	[Command(ProtocolName.Page.Crash)]
	[SupportedBy("Chrome")]
	public class CrashCommand: ICommand<CrashCommandResponse>
	{
	}
}

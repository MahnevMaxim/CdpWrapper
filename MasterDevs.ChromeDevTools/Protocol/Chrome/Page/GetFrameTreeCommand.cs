#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Returns present frame tree structure.
	/// </summary>
	[Command(ProtocolName.Page.GetFrameTree)]
	[SupportedBy("Chrome")]
	public class GetFrameTreeCommand: ICommand<GetFrameTreeCommandResponse>
	{
	}
}

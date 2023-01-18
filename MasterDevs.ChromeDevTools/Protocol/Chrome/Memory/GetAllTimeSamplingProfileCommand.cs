#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Retrieve native memory allocations profile collected since renderer process startup.
	/// </summary>
	[Command(ProtocolName.Memory.GetAllTimeSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetAllTimeSamplingProfileCommand: ICommand<GetAllTimeSamplingProfileCommandResponse>
	{
	}
}

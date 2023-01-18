#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetSamplingProfile)]
	[SupportedBy("Chrome")]
	public class GetSamplingProfileCommand: ICommand<GetSamplingProfileCommandResponse>
	{
	}
}

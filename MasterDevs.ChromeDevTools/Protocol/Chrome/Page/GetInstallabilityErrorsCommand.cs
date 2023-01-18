#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetInstallabilityErrors)]
	[SupportedBy("Chrome")]
	public class GetInstallabilityErrorsCommand: ICommand<GetInstallabilityErrorsCommandResponse>
	{
	}
}

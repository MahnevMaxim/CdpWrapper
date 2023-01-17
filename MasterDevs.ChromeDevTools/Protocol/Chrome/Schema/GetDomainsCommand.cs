using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Schema
{
	/// <summary>
	/// Returns supported domains.
	/// </summary>
	[Command(ProtocolName.Schema.GetDomains)]
	[SupportedBy("Chrome")]
	public class GetDomainsCommand: ICommand<GetDomainsCommandResponse>
	{
	}
}

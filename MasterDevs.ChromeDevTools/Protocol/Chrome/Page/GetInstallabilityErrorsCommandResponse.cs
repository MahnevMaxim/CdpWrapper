using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.GetInstallabilityErrors)]
	[SupportedBy("Chrome")]
	public class GetInstallabilityErrorsCommandResponse
	{
		/// <summary>
		/// Gets or sets InstallabilityErrors
		/// </summary>
		public InstallabilityError[] InstallabilityErrors { get; set; }
	}
}

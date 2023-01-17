using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Schema
{
	/// <summary>
	/// Returns supported domains.
	/// </summary>
	[CommandResponse(ProtocolName.Schema.GetDomains)]
	[SupportedBy("Chrome")]
	public class GetDomainsCommandResponse
	{
		/// <summary>
		/// Gets or sets List of supported domains.
		/// </summary>
		public Domain[] Domains { get; set; }
	}
}

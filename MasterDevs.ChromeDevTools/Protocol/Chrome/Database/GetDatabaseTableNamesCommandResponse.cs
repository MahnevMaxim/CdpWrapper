#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Database
{
	[CommandResponse(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("Chrome")]
	public class GetDatabaseTableNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets TableNames
		/// </summary>
		public string[] TableNames { get; set; }
	}
}

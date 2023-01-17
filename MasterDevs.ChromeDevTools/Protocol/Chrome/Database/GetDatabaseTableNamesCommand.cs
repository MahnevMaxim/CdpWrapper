using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("Chrome")]
	public class GetDatabaseTableNamesCommand: ICommand<GetDatabaseTableNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets DatabaseId
		/// </summary>
		public string DatabaseId { get; set; }
	}
}

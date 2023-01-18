#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("Chrome")]
	public class RequestDatabaseNamesCommand: ICommand<RequestDatabaseNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
	}
}

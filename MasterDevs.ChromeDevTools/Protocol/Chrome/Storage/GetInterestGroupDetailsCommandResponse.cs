using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Gets details for a named interest group.
	/// </summary>
	[CommandResponse(ProtocolName.Storage.GetInterestGroupDetails)]
	[SupportedBy("Chrome")]
	public class GetInterestGroupDetailsCommandResponse
	{
		/// <summary>
		/// Gets or sets Details
		/// </summary>
		public InterestGroupDetails Details { get; set; }
	}
}

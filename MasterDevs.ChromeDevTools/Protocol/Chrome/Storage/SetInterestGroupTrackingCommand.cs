#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	/// Enables/Disables issuing of interestGroupAccessed events.
	/// </summary>
	[Command(ProtocolName.Storage.SetInterestGroupTracking)]
	[SupportedBy("Chrome")]
	public class SetInterestGroupTrackingCommand: ICommand<SetInterestGroupTrackingCommandResponse>
	{
		/// <summary>
		/// Gets or sets Enable
		/// </summary>
		public bool Enable { get; set; }
	}
}

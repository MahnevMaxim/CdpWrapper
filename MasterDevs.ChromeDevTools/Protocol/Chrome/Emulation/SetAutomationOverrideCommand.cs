using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Allows overriding the automation flag.
	/// </summary>
	[Command(ProtocolName.Emulation.SetAutomationOverride)]
	[SupportedBy("Chrome")]
	public class SetAutomationOverrideCommand: ICommand<SetAutomationOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether the override should be enabled.
		/// </summary>
		public bool Enabled { get; set; }
	}
}

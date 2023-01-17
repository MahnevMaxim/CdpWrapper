using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	/// Overrides the Idle state.
	/// </summary>
	[Command(ProtocolName.Emulation.SetIdleOverride)]
	[SupportedBy("Chrome")]
	public class SetIdleOverrideCommand: ICommand<SetIdleOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or sets Mock isUserActive
		/// </summary>
		public bool IsUserActive { get; set; }
		/// <summary>
		/// Gets or sets Mock isScreenUnlocked
		/// </summary>
		public bool IsScreenUnlocked { get; set; }
	}
}

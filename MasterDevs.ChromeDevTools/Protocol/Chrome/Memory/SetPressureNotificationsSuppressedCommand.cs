#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Enable/disable suppressing memory pressure notifications in all processes.
	/// </summary>
	[Command(ProtocolName.Memory.SetPressureNotificationsSuppressed)]
	[SupportedBy("Chrome")]
	public class SetPressureNotificationsSuppressedCommand: ICommand<SetPressureNotificationsSuppressedCommandResponse>
	{
		/// <summary>
		/// Gets or sets If true, memory pressure notifications will be suppressed.
		/// </summary>
		public bool Suppressed { get; set; }
	}
}

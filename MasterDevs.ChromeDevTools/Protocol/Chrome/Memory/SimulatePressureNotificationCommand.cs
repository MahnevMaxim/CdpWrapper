using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Memory
{
	/// <summary>
	/// Simulate a memory pressure notification in all processes.
	/// </summary>
	[Command(ProtocolName.Memory.SimulatePressureNotification)]
	[SupportedBy("Chrome")]
	public class SimulatePressureNotificationCommand: ICommand<SimulatePressureNotificationCommandResponse>
	{
		/// <summary>
		/// Gets or sets Memory pressure level of the notification.
		/// </summary>
		public string Level { get; set; }
	}
}

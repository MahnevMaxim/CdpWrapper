using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Activates (focuses) the target.
	/// </summary>
	[Command(ProtocolName.Target.ActivateTarget)]
	[SupportedBy("Chrome")]
	public class ActivateTargetCommand: ICommand<ActivateTargetCommandResponse>
	{
		/// <summary>
		/// Gets or sets TargetId
		/// </summary>
		public string TargetId { get; set; }
	}
}

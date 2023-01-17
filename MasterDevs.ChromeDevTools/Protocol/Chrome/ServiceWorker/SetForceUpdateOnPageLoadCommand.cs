using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.SetForceUpdateOnPageLoad)]
	[SupportedBy("Chrome")]
	public class SetForceUpdateOnPageLoadCommand: ICommand<SetForceUpdateOnPageLoadCommandResponse>
	{
		/// <summary>
		/// Gets or sets ForceUpdateOnPageLoad
		/// </summary>
		public bool ForceUpdateOnPageLoad { get; set; }
	}
}

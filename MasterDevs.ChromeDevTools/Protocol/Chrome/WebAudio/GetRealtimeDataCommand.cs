using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Fetch the realtime data from the registered contexts.
	/// </summary>
	[Command(ProtocolName.WebAudio.GetRealtimeData)]
	[SupportedBy("Chrome")]
	public class GetRealtimeDataCommand: ICommand<GetRealtimeDataCommandResponse>
	{
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Acknowledges that a screencast frame has been received by the frontend.
	/// </summary>
	[Command(ProtocolName.Page.ScreencastFrameAck)]
	[SupportedBy("Chrome")]
	public class ScreencastFrameAckCommand: ICommand<ScreencastFrameAckCommandResponse>
	{
		/// <summary>
		/// Gets or sets Frame number.
		/// </summary>
		public long SessionId { get; set; }
	}
}

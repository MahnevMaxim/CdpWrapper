using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.BackgroundService
{
	/// <summary>
	/// Set the recording state for the service.
	/// </summary>
	[CommandResponse(ProtocolName.BackgroundService.SetRecording)]
	[SupportedBy("Chrome")]
	public class SetRecordingCommandResponse
	{
	}
}

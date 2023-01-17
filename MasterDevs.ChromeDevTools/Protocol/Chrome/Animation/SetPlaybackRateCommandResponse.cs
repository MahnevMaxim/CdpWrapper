using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SetPlaybackRate)]
	[SupportedBy("Chrome")]
	public class SetPlaybackRateCommandResponse
	{
	}
}

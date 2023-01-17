using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.GetPlaybackRate)]
	[SupportedBy("Chrome")]
	public class GetPlaybackRateCommand: ICommand<GetPlaybackRateCommandResponse>
	{
	}
}

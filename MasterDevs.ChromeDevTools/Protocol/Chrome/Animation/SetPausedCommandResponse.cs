#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Sets the paused state of a set of animations.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.SetPaused)]
	[SupportedBy("Chrome")]
	public class SetPausedCommandResponse
	{
	}
}

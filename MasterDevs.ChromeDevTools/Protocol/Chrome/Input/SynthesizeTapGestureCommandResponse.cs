#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[CommandResponse(ProtocolName.Input.SynthesizeTapGesture)]
	[SupportedBy("Chrome")]
	public class SynthesizeTapGestureCommandResponse
	{
	}
}

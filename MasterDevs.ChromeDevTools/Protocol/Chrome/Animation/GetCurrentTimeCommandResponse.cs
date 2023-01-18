#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	/// Returns the current time of the an animation.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.GetCurrentTime)]
	[SupportedBy("Chrome")]
	public class GetCurrentTimeCommandResponse
	{
		/// <summary>
		/// Gets or sets Current time of the page.
		/// </summary>
		public double CurrentTime { get; set; }
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	/// Collect type profile.
	/// </summary>
	[CommandResponse(ProtocolName.Profiler.TakeTypeProfile)]
	[SupportedBy("Chrome")]
	public class TakeTypeProfileCommandResponse
	{
		/// <summary>
		/// Gets or sets Type profile for all scripts since startTypeProfile() was turned on.
		/// </summary>
		public ScriptTypeProfile[] Result { get; set; }
	}
}

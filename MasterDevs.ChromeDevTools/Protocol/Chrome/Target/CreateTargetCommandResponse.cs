#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	/// Creates a new page.
	/// </summary>
	[CommandResponse(ProtocolName.Target.CreateTarget)]
	[SupportedBy("Chrome")]
	public class CreateTargetCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the page opened.
		/// </summary>
		public string TargetId { get; set; }
	}
}

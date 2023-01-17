using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Resumes JavaScript execution.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Resume)]
	[SupportedBy("Chrome")]
	public class ResumeCommandResponse
	{
	}
}

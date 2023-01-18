#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets files for the given file input element.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetFileInputFiles)]
	[SupportedBy("Chrome")]
	public class SetFileInputFilesCommandResponse
	{
	}
}

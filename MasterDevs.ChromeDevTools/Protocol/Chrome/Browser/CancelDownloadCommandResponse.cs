#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	/// Cancel a download if in progress
	/// </summary>
	[CommandResponse(ProtocolName.Browser.CancelDownload)]
	[SupportedBy("Chrome")]
	public class CancelDownloadCommandResponse
	{
	}
}

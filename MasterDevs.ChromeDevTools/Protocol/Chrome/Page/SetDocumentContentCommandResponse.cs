using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Sets given markup as the document's HTML.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetDocumentContent)]
	[SupportedBy("Chrome")]
	public class SetDocumentContentCommandResponse
	{
	}
}

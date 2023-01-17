using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	/// This method sets the current candidate text for ime. Use imeCommitComposition to commit the final text. Use imeSetComposition with empty string as text to cancel composition.
	/// </summary>
	[CommandResponse(ProtocolName.Input.ImeSetComposition)]
	[SupportedBy("Chrome")]
	public class ImeSetCompositionCommandResponse
	{
	}
}

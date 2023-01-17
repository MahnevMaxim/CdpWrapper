using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Sets attribute for an element with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetAttributeValue)]
	[SupportedBy("Chrome")]
	public class SetAttributeValueCommandResponse
	{
	}
}

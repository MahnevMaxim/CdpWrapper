#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	/// Removes attribute with given name from an element with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.RemoveAttribute)]
	[SupportedBy("Chrome")]
	public class RemoveAttributeCommandResponse
	{
	}
}

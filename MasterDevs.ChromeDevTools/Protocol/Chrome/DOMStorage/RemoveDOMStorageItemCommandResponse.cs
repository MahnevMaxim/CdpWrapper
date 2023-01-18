#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[CommandResponse(ProtocolName.DOMStorage.RemoveDOMStorageItem)]
	[SupportedBy("Chrome")]
	public class RemoveDOMStorageItemCommandResponse
	{
	}
}

using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Tells whether emulation of network conditions is supported.
	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Network.CanEmulateNetworkConditions)]
	[SupportedBy("Chrome")]
	public class CanEmulateNetworkConditionsCommand: ICommand<CanEmulateNetworkConditionsCommandResponse>
	{
	}
}

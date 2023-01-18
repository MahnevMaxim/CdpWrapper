#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.DeviceOrientation
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[CommandResponse(ProtocolName.DeviceOrientation.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommandResponse
	{
	}
}

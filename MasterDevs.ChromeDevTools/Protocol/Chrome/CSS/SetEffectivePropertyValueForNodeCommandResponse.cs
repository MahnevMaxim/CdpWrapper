using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Find a rule with the given active property for the given node and set the new value for this property
	/// </summary>
	[CommandResponse(ProtocolName.CSS.SetEffectivePropertyValueForNode)]
	[SupportedBy("Chrome")]
	public class SetEffectivePropertyValueForNodeCommandResponse
	{
	}
}

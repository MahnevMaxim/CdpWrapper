#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReleaseSnapshot)]
	[SupportedBy("Chrome")]
	public class ReleaseSnapshotCommandResponse
	{
	}
}

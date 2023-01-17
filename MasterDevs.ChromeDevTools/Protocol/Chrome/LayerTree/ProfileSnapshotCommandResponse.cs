using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.LayerTree
{
	[CommandResponse(ProtocolName.LayerTree.ProfileSnapshot)]
	[SupportedBy("Chrome")]
	public class ProfileSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The array of paint profiles, one per run.
		/// </summary>
		public double[][] Timings { get; set; }
	}
}

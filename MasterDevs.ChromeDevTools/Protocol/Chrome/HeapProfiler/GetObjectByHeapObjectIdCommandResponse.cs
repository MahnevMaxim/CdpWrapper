#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetObjectByHeapObjectId)]
	[SupportedBy("Chrome")]
	public class GetObjectByHeapObjectIdCommandResponse
	{
		/// <summary>
		/// Gets or sets Evaluation result.
		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
	}
}

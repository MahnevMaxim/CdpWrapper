#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetHeapObjectId)]
	[SupportedBy("Chrome")]
	public class GetHeapObjectIdCommand: ICommand<GetHeapObjectIdCommandResponse>
	{
		/// <summary>
		/// Gets or sets Identifier of the object to get heap object id for.
		/// </summary>
		public string ObjectId { get; set; }
	}
}

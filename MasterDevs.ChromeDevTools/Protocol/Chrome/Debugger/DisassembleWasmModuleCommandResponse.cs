using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	[CommandResponse(ProtocolName.Debugger.DisassembleWasmModule)]
	[SupportedBy("Chrome")]
	public class DisassembleWasmModuleCommandResponse
	{
		/// <summary>
		/// Gets or sets For large modules, return a stream from which additional chunks of disassembly can be read successively.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StreamId { get; set; }
		/// <summary>
		/// Gets or sets The total number of lines in the disassembly text.
		/// </summary>
		public long TotalNumberOfLines { get; set; }
		/// <summary>
		/// Gets or sets The offsets of all function bodies, in the format [start1, end1, start2, end2, ...] where all ends are exclusive.
		/// </summary>
		public long[] FunctionBodyOffsets { get; set; }
		/// <summary>
		/// Gets or sets The first chunk of disassembly.
		/// </summary>
		public WasmDisassemblyChunk Chunk { get; set; }
	}
}

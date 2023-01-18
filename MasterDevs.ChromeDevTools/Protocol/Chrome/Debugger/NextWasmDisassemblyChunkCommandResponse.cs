#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Disassemble the next chunk of lines for the module corresponding to the stream. If disassembly is complete, this API will invalidate the streamId and return an empty chunk. Any subsequent calls for the now invalid stream will return errors.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.NextWasmDisassemblyChunk)]
	[SupportedBy("Chrome")]
	public class NextWasmDisassemblyChunkCommandResponse
	{
		/// <summary>
		/// Gets or sets The next chunk of disassembly.
		/// </summary>
		public WasmDisassemblyChunk Chunk { get; set; }
	}
}

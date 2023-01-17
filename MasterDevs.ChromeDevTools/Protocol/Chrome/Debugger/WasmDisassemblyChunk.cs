using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	[SupportedBy("Chrome")]
	public class WasmDisassemblyChunk
	{
		/// <summary>
		/// Gets or sets The next chunk of disassembled lines.
		/// </summary>
		public string[] Lines { get; set; }
		/// <summary>
		/// Gets or sets The bytecode offsets describing the start of each line.
		/// </summary>
		public long[] BytecodeOffsets { get; set; }
	}
}

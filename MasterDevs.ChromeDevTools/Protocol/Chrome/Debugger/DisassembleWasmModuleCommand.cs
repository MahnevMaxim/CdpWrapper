using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	[Command(ProtocolName.Debugger.DisassembleWasmModule)]
	[SupportedBy("Chrome")]
	public class DisassembleWasmModuleCommand: ICommand<DisassembleWasmModuleCommandResponse>
	{
		/// <summary>
		/// Gets or sets Id of the script to disassemble
		/// </summary>
		public string ScriptId { get; set; }
	}
}

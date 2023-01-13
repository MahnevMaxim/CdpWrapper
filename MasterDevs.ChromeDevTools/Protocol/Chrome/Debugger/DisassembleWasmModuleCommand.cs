using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
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

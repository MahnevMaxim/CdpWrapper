#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.SetDisabledImageTypes)]
	[SupportedBy("Chrome")]
	public class SetDisabledImageTypesCommand: ICommand<SetDisabledImageTypesCommandResponse>
	{
		/// <summary>
		/// Gets or sets Image types to disable.
		/// </summary>
		public string[] ImageTypes { get; set; }
	}
}

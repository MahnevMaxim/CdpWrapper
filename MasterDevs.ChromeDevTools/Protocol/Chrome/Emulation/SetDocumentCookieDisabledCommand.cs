#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.SetDocumentCookieDisabled)]
	[SupportedBy("Chrome")]
	public class SetDocumentCookieDisabledCommand: ICommand<SetDocumentCookieDisabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets Whether document.coookie API should be disabled.
		/// </summary>
		public bool Disabled { get; set; }
	}
}

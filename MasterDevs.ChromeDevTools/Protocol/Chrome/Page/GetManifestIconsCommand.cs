using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	[Command(ProtocolName.Page.GetManifestIcons)]
	[SupportedBy("Chrome")]
	public class GetManifestIconsCommand: ICommand<GetManifestIconsCommandResponse>
	{
	}
}

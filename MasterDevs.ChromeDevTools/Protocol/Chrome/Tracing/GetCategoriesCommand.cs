using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Tracing
{
	/// <summary>
	/// Gets supported tracing categories.
	/// </summary>
	[Command(ProtocolName.Tracing.GetCategories)]
	[SupportedBy("Chrome")]
	public class GetCategoriesCommand: ICommand<GetCategoriesCommandResponse>
	{
	}
}

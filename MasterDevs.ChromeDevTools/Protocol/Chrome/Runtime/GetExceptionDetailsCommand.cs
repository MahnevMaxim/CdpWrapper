using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// This method tries to lookup and populate exception details for a JavaScript Error object. Note that the stackTrace portion of the resulting exceptionDetails will only be populated if the Runtime domain was enabled at the time when the Error was thrown.
	/// </summary>
	[Command(ProtocolName.Runtime.GetExceptionDetails)]
	[SupportedBy("Chrome")]
	public class GetExceptionDetailsCommand: ICommand<GetExceptionDetailsCommandResponse>
	{
		/// <summary>
		/// Gets or sets The error object for which to resolve the exception details.
		/// </summary>
		public string ErrorObjectId { get; set; }
	}
}

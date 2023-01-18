#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	/// Search match for resource.
	/// </summary>
	[SupportedBy("Chrome")]
	public class SearchMatch
	{
		/// <summary>
		/// Gets or sets Line number in resource content.
		/// </summary>
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Line with match content.
		/// </summary>
		public string LineContent { get; set; }
	}
}

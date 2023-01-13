using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class BackForwardCacheNotRestoredExplanationTree
	{
		/// <summary>
		/// Gets or sets URL of each frame
		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Not restored reasons of each frame
		/// </summary>
		public BackForwardCacheNotRestoredExplanation[] Explanations { get; set; }
		/// <summary>
		/// Gets or sets Array of children frame
		/// </summary>
		public BackForwardCacheNotRestoredExplanationTree[] Children { get; set; }
	}
}

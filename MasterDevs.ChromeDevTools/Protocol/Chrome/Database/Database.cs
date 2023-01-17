using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Database
{
	/// <summary>
	/// Database object.
	/// </summary>
	[SupportedBy("Chrome")]
	public class Database
	{
		/// <summary>
		/// Gets or sets Database ID.
		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets Database domain.
		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Gets or sets Database name.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Database version.
		/// </summary>
		public string Version { get; set; }
	}
}

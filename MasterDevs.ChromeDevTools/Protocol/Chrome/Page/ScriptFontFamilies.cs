using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	/// Font families collection for a script.
	/// </summary>
	[SupportedBy("Chrome")]
	public class ScriptFontFamilies
	{
		/// <summary>
		/// Gets or sets Name of the script which these font families are defined for.
		/// </summary>
		public string Script { get; set; }
		/// <summary>
		/// Gets or sets Generic font families collection for the script.
		/// </summary>
		public FontFamilies FontFamilies { get; set; }
	}
}

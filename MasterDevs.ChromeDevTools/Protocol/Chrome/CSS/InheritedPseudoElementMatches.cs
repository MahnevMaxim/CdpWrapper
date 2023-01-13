using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	/// Inherited pseudo element matches from pseudos of an ancestor node.
	/// </summary>
	[SupportedBy("Chrome")]
	public class InheritedPseudoElementMatches
	{
		/// <summary>
		/// Gets or sets Matches of pseudo styles from the pseudos of an ancestor node.
		/// </summary>
		public PseudoElementMatches[] PseudoElements { get; set; }
	}
}

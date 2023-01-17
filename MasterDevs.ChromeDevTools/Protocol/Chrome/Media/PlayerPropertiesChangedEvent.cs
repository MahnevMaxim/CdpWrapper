using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	/// This can be called multiple times, and can be used to set / override / remove player properties. A null propValue indicates removal.
	/// </summary>
	[Event(ProtocolName.Media.PlayerPropertiesChanged)]
	[SupportedBy("Chrome")]
	public class PlayerPropertiesChangedEvent
	{
		/// <summary>
		/// Gets or sets PlayerId
		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Gets or sets Properties
		/// </summary>
		public PlayerProperty[] Properties { get; set; }
	}
}

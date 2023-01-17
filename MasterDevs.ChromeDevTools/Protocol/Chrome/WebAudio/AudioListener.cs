using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Protocol object for AudioListener
	/// </summary>
	[SupportedBy("Chrome")]
	public class AudioListener
	{
		/// <summary>
		/// Gets or sets ListenerId
		/// </summary>
		public string ListenerId { get; set; }
		/// <summary>
		/// Gets or sets ContextId
		/// </summary>
		public string ContextId { get; set; }
	}
}

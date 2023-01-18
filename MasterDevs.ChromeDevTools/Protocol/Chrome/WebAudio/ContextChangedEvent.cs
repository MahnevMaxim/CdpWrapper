#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that existing BaseAudioContext has changed some properties (id stays the same)..
	/// </summary>
	[Event(ProtocolName.WebAudio.ContextChanged)]
	[SupportedBy("Chrome")]
	public class ContextChangedEvent
	{
		/// <summary>
		/// Gets or sets Context
		/// </summary>
		public BaseAudioContext Context { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	/// Notifies that a new BaseAudioContext has been created.
	/// </summary>
	[Event(ProtocolName.WebAudio.ContextCreated)]
	[SupportedBy("Chrome")]
	public class ContextCreatedEvent
	{
		/// <summary>
		/// Gets or sets Context
		/// </summary>
		public BaseAudioContext Context { get; set; }
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.ServiceWorker{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceWorkerVersionStatus
	{
			New,
			Installing,
			Installed,
			Activating,
			Activated,
			Redundant,
	}
}

#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Storage{
	/// <summary>
	/// Enum of possible storage types.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StorageType
	{
			Appcache,
			Cookies,
			File_systems,
			Indexeddb,
			Local_storage,
			Shader_cache,
			Websql,
			Service_workers,
			Cache_storage,
			Interest_groups,
			All,
			Other,
	}
}

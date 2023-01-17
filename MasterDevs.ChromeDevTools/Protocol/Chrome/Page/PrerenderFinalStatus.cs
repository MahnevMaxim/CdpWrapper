using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Page{
	/// <summary>
	/// List of FinalStatus reasons for Prerender2.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrerenderFinalStatus
	{
			Activated,
			Destroyed,
			LowEndDevice,
			CrossOriginRedirect,
			CrossOriginNavigation,
			InvalidSchemeRedirect,
			InvalidSchemeNavigation,
			InProgressNavigation,
			NavigationRequestBlockedByCsp,
			MainFrameNavigation,
			MojoBinderPolicy,
			RendererProcessCrashed,
			RendererProcessKilled,
			Download,
			TriggerDestroyed,
			NavigationNotCommitted,
			NavigationBadHttpStatus,
			ClientCertRequested,
			NavigationRequestNetworkError,
			MaxNumOfRunningPrerendersExceeded,
			CancelAllHostsForTesting,
			DidFailLoad,
			Stop,
			SslCertificateError,
			LoginAuthRequested,
			UaChangeRequiresReload,
			BlockedByClient,
			AudioOutputDeviceRequested,
			MixedContent,
			TriggerBackgrounded,
			EmbedderTriggeredAndSameOriginRedirected,
			EmbedderTriggeredAndCrossOriginRedirected,
			EmbedderTriggeredAndDestroyed,
			MemoryLimitExceeded,
			FailToGetMemoryUsage,
	}
}

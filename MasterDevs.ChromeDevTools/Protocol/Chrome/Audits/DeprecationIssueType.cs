#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace Mybot.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeprecationIssueType
	{
			AuthorizationCoveredByWildcard,
			CanRequestURLHTTPContainingNewline,
			ChromeLoadTimesConnectionInfo,
			ChromeLoadTimesFirstPaintAfterLoadTime,
			ChromeLoadTimesWasAlternateProtocolAvailable,
			CookieWithTruncatingChar,
			CrossOriginAccessBasedOnDocumentDomain,
			CrossOriginWindowAlert,
			CrossOriginWindowConfirm,
			CSSSelectorInternalMediaControlsOverlayCastButton,
			DeprecationExample,
			DocumentDomainSettingWithoutOriginAgentClusterHeader,
			EventPath,
			ExpectCTHeader,
			GeolocationInsecureOrigin,
			GeolocationInsecureOriginDeprecatedNotRemoved,
			GetUserMediaInsecureOrigin,
			HostCandidateAttributeGetter,
			IdentityInCanMakePaymentEvent,
			InsecurePrivateNetworkSubresourceRequest,
			LegacyConstraintGoogIPv6,
			LocalCSSFileExtensionRejected,
			MediaSourceAbortRemove,
			MediaSourceDurationTruncatingBuffered,
			NavigateEventRestoreScroll,
			NavigateEventTransitionWhile,
			NoSysexWebMIDIWithoutPermission,
			NotificationInsecureOrigin,
			NotificationPermissionRequestedIframe,
			ObsoleteWebRtcCipherSuite,
			OpenWebDatabaseInsecureContext,
			OverflowVisibleOnReplacedElement,
			PersistentQuotaType,
			PictureSourceSrc,
			PrefixedCancelAnimationFrame,
			PrefixedRequestAnimationFrame,
			PrefixedStorageInfo,
			PrefixedVideoDisplayingFullscreen,
			PrefixedVideoEnterFullscreen,
			PrefixedVideoEnterFullScreen,
			PrefixedVideoExitFullscreen,
			PrefixedVideoExitFullScreen,
			PrefixedVideoSupportsFullscreen,
			RangeExpand,
			RequestedSubresourceWithEmbeddedCredentials,
			RTCConstraintEnableDtlsSrtpFalse,
			RTCConstraintEnableDtlsSrtpTrue,
			RTCPeerConnectionComplexPlanBSdpUsingDefaultSdpSemantics,
			RTCPeerConnectionSdpSemanticsPlanB,
			RtcpMuxPolicyNegotiate,
			SharedArrayBufferConstructedWithoutIsolation,
			TextToSpeech_DisallowedByAutoplay,
			V8SharedArrayBufferConstructedInExtensionWithoutIsolation,
			XHRJSONEncodingDetection,
			XMLHttpRequestSynchronousInNonWorkerOutsideBeforeUnload,
			XRSupportsSession,
	}
}

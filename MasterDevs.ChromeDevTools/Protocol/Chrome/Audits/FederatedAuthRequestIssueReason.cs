using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	/// Represents the failure reason when a federated authentication reason fails. Should be updated alongside RequestIdTokenStatus in third_party/blink/public/mojom/devtools/inspector_issue.mojom to include all cases except for success.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FederatedAuthRequestIssueReason
	{
			ApprovalDeclined,
			TooManyRequests,
			ManifestListHttpNotFound,
			ManifestListNoResponse,
			ManifestListInvalidResponse,
			ManifestNotInManifestList,
			ManifestListTooBig,
			ManifestHttpNotFound,
			ManifestNoResponse,
			ManifestInvalidResponse,
			ClientMetadataHttpNotFound,
			ClientMetadataNoResponse,
			ClientMetadataInvalidResponse,
			ClientMetadataMissingPrivacyPolicyUrl,
			DisabledInSettings,
			ErrorFetchingSignin,
			InvalidSigninResponse,
			AccountsHttpNotFound,
			AccountsNoResponse,
			AccountsInvalidResponse,
			IdTokenHttpNotFound,
			IdTokenNoResponse,
			IdTokenInvalidResponse,
			IdTokenInvalidRequest,
			ErrorIdToken,
			Canceled,
	}
}

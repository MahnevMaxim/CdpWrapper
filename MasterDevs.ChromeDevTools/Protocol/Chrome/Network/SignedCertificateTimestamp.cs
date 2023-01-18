#pragma warning disable
using Mybot.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Mybot.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	/// Details of a signed certificate timestamp (SCT).
	/// </summary>
	[SupportedBy("Chrome")]
	public class SignedCertificateTimestamp
	{
		/// <summary>
		/// Gets or sets Validation status.
		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Gets or sets Origin.
		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets Log name / description.
		/// </summary>
		public string LogDescription { get; set; }
		/// <summary>
		/// Gets or sets Log ID.
		/// </summary>
		public string LogId { get; set; }
		/// <summary>
		/// Gets or sets Issuance date. Unlike TimeSinceEpoch, this contains the number of milliseconds since January 1, 1970, UTC, not the number of seconds.
		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Hash algorithm.
		/// </summary>
		public string HashAlgorithm { get; set; }
		/// <summary>
		/// Gets or sets Signature algorithm.
		/// </summary>
		public string SignatureAlgorithm { get; set; }
		/// <summary>
		/// Gets or sets Signature data.
		/// </summary>
		public string SignatureData { get; set; }
	}
}

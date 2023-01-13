using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.StopTrackingHeapObjects)]
	[SupportedBy("Chrome")]
	public class StopTrackingHeapObjectsCommand: ICommand<StopTrackingHeapObjectsCommandResponse>
	{
		/// <summary>
		/// Gets or sets If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken when the tracking is stopped.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReportProgress { get; set; }
		/// <summary>
		/// Gets or sets Deprecated in favor of `exposeInternals`.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? TreatGlobalObjectsAsRoots { get; set; }
		/// <summary>
		/// Gets or sets If true, numerical values are included in the snapshot
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CaptureNumericValue { get; set; }
		/// <summary>
		/// Gets or sets If true, exposes internals of the snapshot.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ExposeInternals { get; set; }
	}
}

using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM{
	/// <summary>
	/// Pseudo element type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PseudoType
	{
			[EnumMember(Value = "first-line")]
			First_line,
			[EnumMember(Value = "first-letter")]
			First_letter,
			Before,
			After,
			Marker,
			Backdrop,
			Selection,
			[EnumMember(Value = "target-text")]
			Target_text,
			[EnumMember(Value = "spelling-error")]
			Spelling_error,
			[EnumMember(Value = "grammar-error")]
			Grammar_error,
			Highlight,
			[EnumMember(Value = "first-line-inherited")]
			First_line_inherited,
			Scrollbar,
			[EnumMember(Value = "scrollbar-thumb")]
			Scrollbar_thumb,
			[EnumMember(Value = "scrollbar-button")]
			Scrollbar_button,
			[EnumMember(Value = "scrollbar-track")]
			Scrollbar_track,
			[EnumMember(Value = "scrollbar-track-piece")]
			Scrollbar_track_piece,
			[EnumMember(Value = "scrollbar-corner")]
			Scrollbar_corner,
			Resizer,
			[EnumMember(Value = "input-list-button")]
			Input_list_button,
			[EnumMember(Value = "page-transition")]
			Page_transition,
			[EnumMember(Value = "page-transition-container")]
			Page_transition_container,
			[EnumMember(Value = "page-transition-image-wrapper")]
			Page_transition_image_wrapper,
			[EnumMember(Value = "page-transition-outgoing-image")]
			Page_transition_outgoing_image,
			[EnumMember(Value = "page-transition-incoming-image")]
			Page_transition_incoming_image,
	}
}

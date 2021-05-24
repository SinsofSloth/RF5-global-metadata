[ExtensionAttribute] // RVA: 0x11E0D0 Offset: 0x11E1D1 VA: 0x11E0D0
internal static class StyleValueExtensions // TypeDefIndex: 4241
{
	// Methods

	[ExtensionAttribute] // RVA: 0x120060 Offset: 0x120161 VA: 0x120060
	// RVA: -1 Offset: -1
	internal static StyleEnum<T> ToStyleEnum<T>(StyleInt styleInt, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34FE1C0 Offset: 0x34FE2C1 VA: 0x34FE1C0
	|-StyleValueExtensions.ToStyleEnum<Int32Enum>
	|-StyleValueExtensions.ToStyleEnum<DisplayStyle>
	|-StyleValueExtensions.ToStyleEnum<Overflow>
	|-StyleValueExtensions.ToStyleEnum<Visibility>
	*/

	[ExtensionAttribute] // RVA: 0x120070 Offset: 0x120171 VA: 0x120070
	// RVA: 0x15CC540 Offset: 0x15CC641 VA: 0x15CC540
	internal static StyleLength ToStyleLength(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x120080 Offset: 0x120181 VA: 0x120080
	// RVA: 0x15CC550 Offset: 0x15CC651 VA: 0x15CC550
	internal static StyleFloat ToStyleFloat(StyleValue styleValue) { }

	[ExtensionAttribute] // RVA: 0x120090 Offset: 0x120191 VA: 0x120090
	// RVA: -1 Offset: -1
	internal static string DebugString<T>(IStyleValue<T> styleValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2563D60 Offset: 0x2563E61 VA: 0x2563D60
	|-StyleValueExtensions.DebugString<int>
	|
	|-RVA: 0x2563F70 Offset: 0x2564071 VA: 0x2563F70
	|-StyleValueExtensions.DebugString<Int32Enum>
	|
	|-RVA: 0x2564180 Offset: 0x2564281 VA: 0x2564180
	|-StyleValueExtensions.DebugString<object>
	|-StyleValueExtensions.DebugString<Font>
	|
	|-RVA: 0x2564380 Offset: 0x2564481 VA: 0x2564380
	|-StyleValueExtensions.DebugString<float>
	|
	|-RVA: 0x2564590 Offset: 0x2564691 VA: 0x2564590
	|-StyleValueExtensions.DebugString<Color>
	|
	|-RVA: 0x21CAB50 Offset: 0x21CAC51 VA: 0x21CAB50
	|-StyleValueExtensions.DebugString<Length>
	*/
}


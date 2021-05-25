[ExtensionAttribute] // RVA: 0x12A760 Offset: 0x12A861 VA: 0x12A760
internal static class TimelineClipCapsExtensions // TypeDefIndex: 4572
{
	// Methods

	[ExtensionAttribute] // RVA: 0x12C1F0 Offset: 0x12C2F1 VA: 0x12C1F0
	// RVA: 0x1B3B340 Offset: 0x1B3B441 VA: 0x1B3B340
	public static bool SupportsLooping(TimelineClip clip) { }

	[ExtensionAttribute] // RVA: 0x12C200 Offset: 0x12C301 VA: 0x12C200
	// RVA: 0x1B3B360 Offset: 0x1B3B461 VA: 0x1B3B360
	public static bool SupportsExtrapolation(TimelineClip clip) { }

	[ExtensionAttribute] // RVA: 0x12C210 Offset: 0x12C311 VA: 0x12C210
	// RVA: 0x1B3B380 Offset: 0x1B3B481 VA: 0x1B3B380
	public static bool SupportsClipIn(TimelineClip clip) { }

	[ExtensionAttribute] // RVA: 0x12C220 Offset: 0x12C321 VA: 0x12C220
	// RVA: 0x1B3B3A0 Offset: 0x1B3B4A1 VA: 0x1B3B3A0
	public static bool SupportsSpeedMultiplier(TimelineClip clip) { }

	[ExtensionAttribute] // RVA: 0x12C230 Offset: 0x12C331 VA: 0x12C230
	// RVA: 0x1B3B3C0 Offset: 0x1B3B4C1 VA: 0x1B3B3C0
	public static bool SupportsBlending(TimelineClip clip) { }

	[ExtensionAttribute] // RVA: 0x12C240 Offset: 0x12C341 VA: 0x12C240
	// RVA: 0x1B3B3E0 Offset: 0x1B3B4E1 VA: 0x1B3B3E0
	public static bool HasAll(ClipCaps caps, ClipCaps flags) { }

	[ExtensionAttribute] // RVA: 0x12C250 Offset: 0x12C351 VA: 0x12C250
	// RVA: 0x1B38970 Offset: 0x1B38A71 VA: 0x1B38970
	public static bool HasAny(ClipCaps caps, ClipCaps flags) { }
}


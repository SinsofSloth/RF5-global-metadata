[NativeHeaderAttribute] // RVA: 0xC4E40 Offset: 0xC4F41 VA: 0xC4E40
[NativeHeaderAttribute] // RVA: 0xC4E40 Offset: 0xC4F41 VA: 0xC4E40
[StaticAccessorAttribute] // RVA: 0xC4E40 Offset: 0xC4F41 VA: 0xC4E40
public sealed class QualitySettings : Object // TypeDefIndex: 2881
{
	// Properties
	public static int pixelLightCount { get; set; }
	public static float shadowDistance { set; }
	[NativePropertyAttribute] // RVA: 0xDE470 Offset: 0xDE571 VA: 0xDE470
	public static ShadowResolution shadowResolution { set; }
	public static int vSyncCount { get; set; }
	public static int antiAliasing { get; }
	[NativePropertyAttribute] // RVA: 0xDE4B0 Offset: 0xDE5B1 VA: 0xDE4B0
	public static string[] names { get; }
	public static ColorSpace desiredColorSpace { get; }
	public static ColorSpace activeColorSpace { get; }

	// Methods

	// RVA: 0x2B73AC0 Offset: 0x2B73BC1 VA: 0x2B73AC0
	public static void IncreaseLevel(bool applyExpensiveChanges) { }

	// RVA: 0x2B73BD0 Offset: 0x2B73CD1 VA: 0x2B73BD0
	public static void DecreaseLevel(bool applyExpensiveChanges) { }

	// RVA: 0x2B73C50 Offset: 0x2B73D51 VA: 0x2B73C50
	public static int get_pixelLightCount() { }

	// RVA: 0x2B73C90 Offset: 0x2B73D91 VA: 0x2B73C90
	public static void set_pixelLightCount(int value) { }

	// RVA: 0x2B73CE0 Offset: 0x2B73DE1 VA: 0x2B73CE0
	public static void set_shadowDistance(float value) { }

	// RVA: 0x2B73D30 Offset: 0x2B73E31 VA: 0x2B73D30
	public static void set_shadowResolution(ShadowResolution value) { }

	// RVA: 0x2B73D80 Offset: 0x2B73E81 VA: 0x2B73D80
	public static int get_vSyncCount() { }

	// RVA: 0x2B73DC0 Offset: 0x2B73EC1 VA: 0x2B73DC0
	public static void set_vSyncCount(int value) { }

	// RVA: 0x2B73E10 Offset: 0x2B73F11 VA: 0x2B73E10
	public static int get_antiAliasing() { }

	[NativeNameAttribute] // RVA: 0xCEDE0 Offset: 0xCEEE1 VA: 0xCEDE0
	// RVA: 0x2B73B40 Offset: 0x2B73C41 VA: 0x2B73B40
	public static int GetQualityLevel() { }

	[NativeNameAttribute] // RVA: 0xCEE20 Offset: 0xCEF21 VA: 0xCEE20
	// RVA: 0x2B73B80 Offset: 0x2B73C81 VA: 0x2B73B80
	public static void SetQualityLevel(int index, bool applyExpensiveChanges) { }

	// RVA: 0x2B73E50 Offset: 0x2B73F51 VA: 0x2B73E50
	public static string[] get_names() { }

	[StaticAccessorAttribute] // RVA: 0xCEE60 Offset: 0xCEF61 VA: 0xCEE60
	[NativeNameAttribute] // RVA: 0xCEE60 Offset: 0xCEF61 VA: 0xCEE60
	// RVA: 0x2B73E90 Offset: 0x2B73F91 VA: 0x2B73E90
	public static ColorSpace get_desiredColorSpace() { }

	[StaticAccessorAttribute] // RVA: 0xCEED0 Offset: 0xCEFD1 VA: 0xCEED0
	[NativeNameAttribute] // RVA: 0xCEED0 Offset: 0xCEFD1 VA: 0xCEED0
	// RVA: 0x2B73ED0 Offset: 0x2B73FD1 VA: 0x2B73ED0
	public static ColorSpace get_activeColorSpace() { }
}


[NativeHeaderAttribute] // RVA: 0xC4CF0 Offset: 0xC4DF1 VA: 0xC4CF0
[StaticAccessorAttribute] // RVA: 0xC4CF0 Offset: 0xC4DF1 VA: 0xC4CF0
public sealed class LightmapSettings : Object // TypeDefIndex: 2877
{
	// Properties
	public static LightmapData[] lightmaps { get; set; }
	public static LightmapsMode lightmapsMode { get; set; }
	public static LightProbes lightProbes { get; set; }
	[ObsoleteAttribute] // RVA: 0xDE390 Offset: 0xDE491 VA: 0xDE390
	public static LightmapsModeLegacy lightmapsModeLegacy { get; set; }
	[ObsoleteAttribute] // RVA: 0xDE3D0 Offset: 0xDE4D1 VA: 0xDE3D0
	public static ColorSpace bakedColorSpace { get; set; }

	// Methods

	// RVA: 0x1A2F520 Offset: 0x1A2F621 VA: 0x1A2F520
	private void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xCE9D0 Offset: 0xCEAD1 VA: 0xCE9D0
	// RVA: 0x1A2F590 Offset: 0x1A2F691 VA: 0x1A2F590
	public static LightmapData[] get_lightmaps() { }

	[FreeFunctionAttribute] // RVA: 0xCE9E0 Offset: 0xCEAE1 VA: 0xCE9E0
	// RVA: 0x1A2F5D0 Offset: 0x1A2F6D1 VA: 0x1A2F5D0
	public static void set_lightmaps(LightmapData[] value) { }

	// RVA: 0x1A2F620 Offset: 0x1A2F721 VA: 0x1A2F620
	public static LightmapsMode get_lightmapsMode() { }

	[FreeFunctionAttribute] // RVA: 0xCE9F0 Offset: 0xCEAF1 VA: 0xCE9F0
	// RVA: 0x1A2F660 Offset: 0x1A2F761 VA: 0x1A2F660
	public static void set_lightmapsMode(LightmapsMode value) { }

	// RVA: 0x1A2F6B0 Offset: 0x1A2F7B1 VA: 0x1A2F6B0
	public static LightProbes get_lightProbes() { }

	[FreeFunctionAttribute] // RVA: 0xCEA30 Offset: 0xCEB31 VA: 0xCEA30
	[NativeNameAttribute] // RVA: 0xCEA30 Offset: 0xCEB31 VA: 0xCEA30
	// RVA: 0x1A2F6F0 Offset: 0x1A2F7F1 VA: 0x1A2F6F0
	public static void set_lightProbes(LightProbes value) { }

	[NativeNameAttribute] // RVA: 0xCEA80 Offset: 0xCEB81 VA: 0xCEA80
	// RVA: 0x1A2F740 Offset: 0x1A2F841 VA: 0x1A2F740
	internal static void Reset() { }

	// RVA: 0x1A2F780 Offset: 0x1A2F881 VA: 0x1A2F780
	public static LightmapsModeLegacy get_lightmapsModeLegacy() { }

	// RVA: 0x1A2F790 Offset: 0x1A2F891 VA: 0x1A2F790
	public static void set_lightmapsModeLegacy(LightmapsModeLegacy value) { }

	// RVA: 0x1A2F7A0 Offset: 0x1A2F8A1 VA: 0x1A2F7A0
	public static ColorSpace get_bakedColorSpace() { }

	// RVA: 0x1A2F7B0 Offset: 0x1A2F8B1 VA: 0x1A2F7B0
	public static void set_bakedColorSpace(ColorSpace value) { }
}


public static class Lightmapping // TypeDefIndex: 3377
{
	// Fields
	[RequiredByNativeCodeAttribute] // RVA: 0xCC030 Offset: 0xCC131 VA: 0xCC030
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCodeAttribute] // RVA: 0xCC040 Offset: 0xCC141 VA: 0xCC040
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xDB1C0 Offset: 0xDB2C1 VA: 0xDB1C0
	// RVA: 0x2B0AEC0 Offset: 0x2B0AFC1 VA: 0x2B0AEC0
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xDB1D0 Offset: 0xDB2D1 VA: 0xDB1D0
	// RVA: 0x2B0AF70 Offset: 0x2B0B071 VA: 0x2B0AF70
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xDB1E0 Offset: 0xDB2E1 VA: 0xDB1E0
	// RVA: 0x2B0AFE0 Offset: 0x2B0B0E1 VA: 0x2B0AFE0
	public static void ResetDelegate() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xDB1F0 Offset: 0xDB2F1 VA: 0xDB1F0
	// RVA: 0x2B0B050 Offset: 0x2B0B151 VA: 0x2B0B050
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x2B0B590 Offset: 0x2B0B691 VA: 0x2B0B590
	private static void .cctor() { }
}


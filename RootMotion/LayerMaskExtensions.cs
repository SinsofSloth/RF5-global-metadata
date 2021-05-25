[ExtensionAttribute] // RVA: 0x147D70 Offset: 0x147E71 VA: 0x147D70
public static class LayerMaskExtensions // TypeDefIndex: 9322
{
	// Methods

	// RVA: 0x1D64B10 Offset: 0x1D64C11 VA: 0x1D64B10
	public static bool Contains(LayerMask mask, int layer) { }

	// RVA: 0x1D64B70 Offset: 0x1D64C71 VA: 0x1D64B70
	public static LayerMask Create(string[] layerNames) { }

	// RVA: 0x1D64C50 Offset: 0x1D64D51 VA: 0x1D64C50
	public static LayerMask Create(int[] layerNumbers) { }

	// RVA: 0x1D64B90 Offset: 0x1D64C91 VA: 0x1D64B90
	public static LayerMask NamesToMask(string[] layerNames) { }

	// RVA: 0x1D64C70 Offset: 0x1D64D71 VA: 0x1D64C70
	public static LayerMask LayerNumbersToMask(int[] layerNumbers) { }

	[ExtensionAttribute] // RVA: 0x1A9F10 Offset: 0x1AA011 VA: 0x1A9F10
	// RVA: 0x1D64D20 Offset: 0x1D64E21 VA: 0x1D64D20
	public static LayerMask Inverse(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x1A9F20 Offset: 0x1AA021 VA: 0x1A9F20
	// RVA: 0x1D64D50 Offset: 0x1D64E51 VA: 0x1D64D50
	public static LayerMask AddToMask(LayerMask original, string[] layerNames) { }

	[ExtensionAttribute] // RVA: 0x1A9F30 Offset: 0x1AA031 VA: 0x1A9F30
	// RVA: 0x1D64DA0 Offset: 0x1D64EA1 VA: 0x1D64DA0
	public static LayerMask RemoveFromMask(LayerMask original, string[] layerNames) { }

	[ExtensionAttribute] // RVA: 0x1A9F40 Offset: 0x1AA041 VA: 0x1A9F40
	// RVA: 0x1D64E10 Offset: 0x1D64F11 VA: 0x1D64E10
	public static string[] MaskToNames(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x1A9F50 Offset: 0x1AA051 VA: 0x1A9F50
	// RVA: 0x1D64F50 Offset: 0x1D65051 VA: 0x1D64F50
	public static int[] MaskToNumbers(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x1A9F60 Offset: 0x1AA061 VA: 0x1A9F60
	// RVA: 0x1D65230 Offset: 0x1D65331 VA: 0x1D65230
	public static string MaskToString(LayerMask original) { }

	[ExtensionAttribute] // RVA: 0x1A9F70 Offset: 0x1AA071 VA: 0x1A9F70
	// RVA: 0x1D65290 Offset: 0x1D65391 VA: 0x1D65290
	public static string MaskToString(LayerMask original, string delimiter) { }
}


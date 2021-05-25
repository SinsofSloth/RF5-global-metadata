[ExtensionAttribute] // RVA: 0x14A600 Offset: 0x14A701 VA: 0x14A600
public static class PrimitiveExtensions // TypeDefIndex: 10435
{
	// Methods

	[ExtensionAttribute] // RVA: 0x1AF350 Offset: 0x1AF451 VA: 0x1AF350
	// RVA: 0x1C754D0 Offset: 0x1C755D1 VA: 0x1C754D0
	public static int ClampIndex(int value, int min, int max) { }

	[ExtensionAttribute] // RVA: 0x1AF360 Offset: 0x1AF461 VA: 0x1AF360
	// RVA: 0x1C754F0 Offset: 0x1C755F1 VA: 0x1C754F0
	public static bool IsValidAsType(string input, Type type) { }

	[ExtensionAttribute] // RVA: 0x1AF370 Offset: 0x1AF471 VA: 0x1AF370
	// RVA: -1 Offset: -1
	public static T ConvertToType<T>(string input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2264540 Offset: 0x2264641 VA: 0x2264540
	|-PrimitiveExtensions.ConvertToType<bool>
	|
	|-RVA: 0x22647E0 Offset: 0x22648E1 VA: 0x22647E0
	|-PrimitiveExtensions.ConvertToType<int>
	|
	|-RVA: 0x2264A80 Offset: 0x2264B81 VA: 0x2264A80
	|-PrimitiveExtensions.ConvertToType<object>
	|
	|-RVA: 0x2264D30 Offset: 0x2264E31 VA: 0x2264D30
	|-PrimitiveExtensions.ConvertToType<float>
	*/

	[ExtensionAttribute] // RVA: 0x1AF380 Offset: 0x1AF481 VA: 0x1AF380
	// RVA: 0x1C756D0 Offset: 0x1C757D1 VA: 0x1C756D0
	public static double RoundUpToNearest(double passednumber, double roundto) { }

	[ExtensionAttribute] // RVA: 0x1AF390 Offset: 0x1AF491 VA: 0x1AF390
	// RVA: 0x1C75760 Offset: 0x1C75861 VA: 0x1C75760
	public static double RoundDownToNearest(double passednumber, double roundto) { }

	[ExtensionAttribute] // RVA: 0x1AF3A0 Offset: 0x1AF4A1 VA: 0x1AF3A0
	// RVA: 0x1C757F0 Offset: 0x1C758F1 VA: 0x1C757F0
	public static float RoundUpToNearest(float passednumber, float roundto) { }

	[ExtensionAttribute] // RVA: 0x1AF3B0 Offset: 0x1AF4B1 VA: 0x1AF3B0
	// RVA: 0x1C75880 Offset: 0x1C75981 VA: 0x1C75880
	public static float RoundDownToNearest(float passednumber, float roundto) { }

	[ExtensionAttribute] // RVA: 0x1AF3C0 Offset: 0x1AF4C1 VA: 0x1AF3C0
	// RVA: 0x1C75910 Offset: 0x1C75A11 VA: 0x1C75910
	public static int RoundUpToNearest(int passednumber, int roundto) { }

	[ExtensionAttribute] // RVA: 0x1AF3D0 Offset: 0x1AF4D1 VA: 0x1AF3D0
	// RVA: 0x1C759A0 Offset: 0x1C75AA1 VA: 0x1C759A0
	public static int RoundDownToNearest(int passednumber, int roundto) { }

	[ExtensionAttribute] // RVA: 0x1AF3E0 Offset: 0x1AF4E1 VA: 0x1AF3E0
	// RVA: 0x1C75A30 Offset: 0x1C75B31 VA: 0x1C75A30
	public static int Flip(int value) { }
}


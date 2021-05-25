[NativeHeaderAttribute] // RVA: 0x10F590 Offset: 0x10F691 VA: 0x10F590
[NativeHeaderAttribute] // RVA: 0x10F590 Offset: 0x10F691 VA: 0x10F590
internal class NativeInputSystem // TypeDefIndex: 3811
{
	// Fields
	public static NativeUpdateCallback onUpdate; // 0x0
	public static Action<NativeInputUpdateType> onBeforeUpdate; // 0x8
	public static Func<NativeInputUpdateType, bool> onShouldRunUpdate; // 0x10
	private static Action<int, string> s_OnDeviceDiscoveredCallback; // 0x18

	// Properties
	internal static bool hasDeviceDiscoveredCallback { set; }

	// Methods

	// RVA: 0x1BE2340 Offset: 0x1BE2441 VA: 0x1BE2340
	private static void .cctor() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10F5F0 Offset: 0x10F6F1 VA: 0x10F5F0
	// RVA: 0x1BE23E0 Offset: 0x1BE24E1 VA: 0x1BE23E0
	internal static void NotifyBeforeUpdate(NativeInputUpdateType updateType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10F600 Offset: 0x10F701 VA: 0x10F600
	// RVA: 0x1BE2480 Offset: 0x1BE2581 VA: 0x1BE2480
	internal static void NotifyUpdate(NativeInputUpdateType updateType, IntPtr eventBuffer) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10F610 Offset: 0x10F711 VA: 0x10F610
	// RVA: 0x1BE2800 Offset: 0x1BE2901 VA: 0x1BE2800
	internal static void NotifyDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x10F620 Offset: 0x10F721 VA: 0x10F620
	// RVA: 0x1BE28B0 Offset: 0x1BE29B1 VA: 0x1BE28B0
	internal static void ShouldRunUpdate(NativeInputUpdateType updateType, out bool retval) { }

	// RVA: 0x1BE2390 Offset: 0x1BE2491 VA: 0x1BE2390
	internal static void set_hasDeviceDiscoveredCallback(bool value) { }
}


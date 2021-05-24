public static class PointerType // TypeDefIndex: 4210
{
	// Fields
	public static readonly string mouse; // 0x0
	public static readonly string touch; // 0x8
	public static readonly string pen; // 0x10
	public static readonly string unknown; // 0x18

	// Methods

	// RVA: 0x15C8470 Offset: 0x15C8571 VA: 0x15C8470
	internal static string GetPointerType(int pointerId) { }

	// RVA: 0x15C53E0 Offset: 0x15C54E1 VA: 0x15C53E0
	internal static bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0x15C8540 Offset: 0x15C8641 VA: 0x15C8540
	private static void .cctor() { }
}


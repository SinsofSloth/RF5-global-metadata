[DefaultMemberAttribute] // RVA: 0xAB120 Offset: 0xAB221 VA: 0xAB120
internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 9
{
	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x11330 Offset: 0x11431 VA: 0x11330
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x11360 Offset: 0x11461 VA: 0x11360
	internal int get_Length() { }

	// RVA: 0x11380 Offset: 0x11481 VA: 0x11380
	internal IntPtr get_Item(int i) { }

	// RVA: 0x11420 Offset: 0x11521 VA: 0x11420
	internal IntPtr Lookup(int i) { }

	// RVA: 0x1940130 Offset: 0x1940231 VA: 0x1940130
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x1940140 Offset: 0x1940241 VA: 0x1940140
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }
}


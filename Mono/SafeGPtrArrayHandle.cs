[DefaultMemberAttribute] // RVA: 0xAB1A0 Offset: 0xAB2A1 VA: 0xAB1A0
internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 20
{
	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x115D0 Offset: 0x116D1 VA: 0x115D0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x11600 Offset: 0x11701 VA: 0x11600 Slot: 4
	public void Dispose() { }

	// RVA: 0x11630 Offset: 0x11731 VA: 0x11630
	internal int get_Length() { }

	// RVA: 0x11650 Offset: 0x11751 VA: 0x11650
	internal IntPtr get_Item(int i) { }
}


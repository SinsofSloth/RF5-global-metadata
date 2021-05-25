private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 774
{
	// Fields
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B920D0 Offset: 0x2B921D1 VA: 0x2B920D0
	|-ThreadLocal.FinalizationHelper<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B92130 Offset: 0x2B92231 VA: 0x2B92130
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	*/
}


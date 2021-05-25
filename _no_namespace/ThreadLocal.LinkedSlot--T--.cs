private sealed class ThreadLocal.LinkedSlot<T> // TypeDefIndex: 772
{
	// Fields
	internal ThreadLocal.LinkedSlot<T> Next; // 0x0
	internal ThreadLocal.LinkedSlot<T> Previous; // 0x0
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	internal T Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B927C0 Offset: 0x2B928C1 VA: 0x2B927C0
	|-ThreadLocal.LinkedSlot<object>..ctor
	*/
}


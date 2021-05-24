[ComVisibleAttribute] // RVA: 0xB20D0 Offset: 0xB21D1 VA: 0xB20D0
public interface ICustomMarshaler // TypeDefIndex: 1318
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object MarshalNativeToManaged(IntPtr pNativeData) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IntPtr MarshalManagedToNative(object ManagedObj) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CleanUpNativeData(IntPtr pNativeData) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CleanUpManagedData(object ManagedObj) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetNativeDataSize() { }
}


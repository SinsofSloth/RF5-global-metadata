[ComVisibleAttribute] // RVA: 0xB0BA0 Offset: 0xB0CA1 VA: 0xB0BA0
public interface ITrackingHandler // TypeDefIndex: 1130
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DisconnectedObject(object obj) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarshaledObject(object obj, ObjRef or) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnmarshaledObject(object obj, ObjRef or) { }
}


public sealed class PinEntryControlCallback : MulticastDelegate // TypeDefIndex: 5587
{
	// Methods

	// RVA: 0x1539F30 Offset: 0x153A031 VA: 0x1539F30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1547570 Offset: 0x1547671 VA: 0x1547570 Slot: 13
	public virtual void Invoke(IList<int> result, bool didCancel) { }

	// RVA: 0x1547C00 Offset: 0x1547D01 VA: 0x1547C00 Slot: 14
	public virtual IAsyncResult BeginInvoke(IList<int> result, bool didCancel, AsyncCallback callback, object object) { }

	// RVA: 0x1547CA0 Offset: 0x1547DA1 VA: 0x1547CA0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 798
{
	// Methods

	// RVA: 0x1A12260 Offset: 0x1A12361 VA: 0x1A12260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A12480 Offset: 0x1A12581 VA: 0x1A12480 Slot: 13
	public virtual void Invoke(IntPtr arg) { }

	// RVA: 0x1A12720 Offset: 0x1A12821 VA: 0x1A12720 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr arg, AsyncCallback callback, object object) { }

	// RVA: 0x1A127B0 Offset: 0x1A128B1 VA: 0x1A127B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


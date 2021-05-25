public sealed class Warning.Logger : MulticastDelegate // TypeDefIndex: 9329
{
	// Methods

	// RVA: 0x1D684E0 Offset: 0x1D685E1 VA: 0x1D684E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D68040 Offset: 0x1D68141 VA: 0x1D68040 Slot: 13
	public virtual void Invoke(string message) { }

	// RVA: 0x1D68500 Offset: 0x1D68601 VA: 0x1D68500 Slot: 14
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x1D68530 Offset: 0x1D68631 VA: 0x1D68530 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


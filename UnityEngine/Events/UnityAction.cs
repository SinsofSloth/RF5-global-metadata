public sealed class UnityAction : MulticastDelegate // TypeDefIndex: 3106
{
	// Methods

	// RVA: 0x2B09160 Offset: 0x2B09261 VA: 0x2B09160
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2AF83B0 Offset: 0x2AF84B1 VA: 0x2AF83B0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2B09180 Offset: 0x2B09281 VA: 0x2B09180 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2B091B0 Offset: 0x2B092B1 VA: 0x2B091B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


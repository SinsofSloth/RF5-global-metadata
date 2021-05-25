public sealed class PinEntryCompleteCallback : MulticastDelegate // TypeDefIndex: 5618
{
	// Methods

	// RVA: 0x153E400 Offset: 0x153E501 VA: 0x153E400
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1539A90 Offset: 0x1539B91 VA: 0x1539A90 Slot: 13
	public virtual void Invoke(bool validPinEntered) { }

	// RVA: 0x15425B0 Offset: 0x15426B1 VA: 0x15425B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool validPinEntered, AsyncCallback callback, object object) { }

	// RVA: 0x1542640 Offset: 0x1542741 VA: 0x1542640 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


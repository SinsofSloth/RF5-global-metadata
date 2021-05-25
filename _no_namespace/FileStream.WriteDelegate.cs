private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 687
{
	// Methods

	// RVA: 0x18A8DF0 Offset: 0x18A8EF1 VA: 0x18A8DF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18AA2A0 Offset: 0x18AA3A1 VA: 0x18AA2A0 Slot: 13
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A8E10 Offset: 0x18A8F11 VA: 0x18A8E10 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x18A9210 Offset: 0x18A9311 VA: 0x18A9210 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


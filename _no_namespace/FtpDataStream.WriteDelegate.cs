private sealed class FtpDataStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 1967
{
	// Methods

	// RVA: 0x1782590 Offset: 0x1782691 VA: 0x1782590
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1782FD0 Offset: 0x17830D1 VA: 0x1782FD0 Slot: 13
	public virtual void Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x17825B0 Offset: 0x17826B1 VA: 0x17825B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x1782780 Offset: 0x1782881 VA: 0x1782780 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


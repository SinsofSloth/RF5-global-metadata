private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 686
{
	// Methods

	// RVA: 0x18A7F80 Offset: 0x18A8081 VA: 0x18A7F80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18A9E20 Offset: 0x18A9F21 VA: 0x18A9E20 Slot: 13
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x18A7FA0 Offset: 0x18A80A1 VA: 0x18A7FA0 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x18A83D0 Offset: 0x18A84D1 VA: 0x18A83D0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}


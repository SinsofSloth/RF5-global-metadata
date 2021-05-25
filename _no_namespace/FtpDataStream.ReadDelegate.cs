private sealed class FtpDataStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 1968
{
	// Methods

	// RVA: 0x1781E20 Offset: 0x1781F21 VA: 0x1781E20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1782B50 Offset: 0x1782C51 VA: 0x1782B50 Slot: 13
	public virtual int Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1781E40 Offset: 0x1781F41 VA: 0x1781E40 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x1782030 Offset: 0x1782131 VA: 0x1782030 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}


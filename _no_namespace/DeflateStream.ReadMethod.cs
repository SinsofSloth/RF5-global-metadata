private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 1866
{
	// Methods

	// RVA: 0x28EC5D0 Offset: 0x28EC6D1 VA: 0x28EC5D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x28ECEC0 Offset: 0x28ECFC1 VA: 0x28ECEC0 Slot: 13
	public virtual int Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x28EC5F0 Offset: 0x28EC6F1 VA: 0x28EC5F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x28ECB50 Offset: 0x28ECC51 VA: 0x28ECB50 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}


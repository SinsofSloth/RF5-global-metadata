private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 1867
{
	// Methods

	// RVA: 0x28EC940 Offset: 0x28ECA41 VA: 0x28EC940
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x28ED340 Offset: 0x28ED441 VA: 0x28ED340 Slot: 13
	public virtual void Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x28EC960 Offset: 0x28ECA61 VA: 0x28EC960 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x28ECCA0 Offset: 0x28ECDA1 VA: 0x28ECCA0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


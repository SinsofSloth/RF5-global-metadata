[UnmanagedFunctionPointerAttribute] // RVA: 0xBC200 Offset: 0xBC301 VA: 0xBC200
private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 1869
{
	// Methods

	// RVA: 0x28ED960 Offset: 0x28EDA61 VA: 0x28ED960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x28EE0C0 Offset: 0x28EE1C1 VA: 0x28EE0C0 Slot: 13
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x28EE390 Offset: 0x28EE491 VA: 0x28EE390 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	// RVA: 0x28EE450 Offset: 0x28EE551 VA: 0x28EE450 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}


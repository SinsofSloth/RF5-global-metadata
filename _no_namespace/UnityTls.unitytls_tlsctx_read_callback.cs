[UnmanagedFunctionPointerAttribute] // RVA: 0xBB7F0 Offset: 0xBB8F1 VA: 0xBB7F0
public sealed class UnityTls.unitytls_tlsctx_read_callback : MulticastDelegate // TypeDefIndex: 1644
{
	// Methods

	// RVA: 0x16FF7F0 Offset: 0x16FF8F1 VA: 0x16FF7F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FF810 Offset: 0x16FF911 VA: 0x16FF810 Slot: 13
	public virtual IntPtr Invoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FFAF0 Offset: 0x16FFBF1 VA: 0x16FFAF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FFBA0 Offset: 0x16FFCA1 VA: 0x16FFBA0 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}


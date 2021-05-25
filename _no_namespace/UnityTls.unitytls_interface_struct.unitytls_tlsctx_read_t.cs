[UnmanagedFunctionPointerAttribute] // RVA: 0xBBB90 Offset: 0xBBC91 VA: 0xBBB90
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t : MulticastDelegate // TypeDefIndex: 1675
{
	// Methods

	// RVA: 0x16FC2A0 Offset: 0x16FC3A1 VA: 0x16FC2A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FC2C0 Offset: 0x16FC3C1 VA: 0x16FC2C0 Slot: 13
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FC5A0 Offset: 0x16FC6A1 VA: 0x16FC5A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FC650 Offset: 0x16FC751 VA: 0x16FC650 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}


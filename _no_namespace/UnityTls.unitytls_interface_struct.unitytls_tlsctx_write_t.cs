[UnmanagedFunctionPointerAttribute] // RVA: 0xBBBB0 Offset: 0xBBCB1 VA: 0xBBBB0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t : MulticastDelegate // TypeDefIndex: 1676
{
	// Methods

	// RVA: 0x16FD780 Offset: 0x16FD881 VA: 0x16FD780
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FD7A0 Offset: 0x16FD8A1 VA: 0x16FD7A0 Slot: 13
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FDA80 Offset: 0x16FDB81 VA: 0x16FDA80 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FDB30 Offset: 0x16FDC31 VA: 0x16FDB30 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}


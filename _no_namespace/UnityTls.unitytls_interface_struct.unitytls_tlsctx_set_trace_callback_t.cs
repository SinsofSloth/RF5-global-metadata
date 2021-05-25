[UnmanagedFunctionPointerAttribute] // RVA: 0xBBAD0 Offset: 0xBBBD1 VA: 0xBBAD0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t : MulticastDelegate // TypeDefIndex: 1669
{
	// Methods

	// RVA: 0x16FD100 Offset: 0x16FD201 VA: 0x16FD100
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FD120 Offset: 0x16FD221 VA: 0x16FD120 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FD3F0 Offset: 0x16FD4F1 VA: 0x16FD3F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FD430 Offset: 0x16FD531 VA: 0x16FD430 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


[UnmanagedFunctionPointerAttribute] // RVA: 0xBBAF0 Offset: 0xBBBF1 VA: 0xBBAF0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate // TypeDefIndex: 1670
{
	// Methods

	// RVA: 0x16FD440 Offset: 0x16FD541 VA: 0x16FD440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FD460 Offset: 0x16FD561 VA: 0x16FD460 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FD730 Offset: 0x16FD831 VA: 0x16FD730 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FD770 Offset: 0x16FD871 VA: 0x16FD770 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


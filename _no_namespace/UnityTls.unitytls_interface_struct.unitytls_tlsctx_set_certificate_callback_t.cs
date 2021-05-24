[UnmanagedFunctionPointerAttribute] // RVA: 0xBBAB0 Offset: 0xBBBB1 VA: 0xBBAB0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate // TypeDefIndex: 1668
{
	// Methods

	// RVA: 0x16FCA10 Offset: 0x16FCB11 VA: 0x16FCA10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FCA30 Offset: 0x16FCB31 VA: 0x16FCA30 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FCD00 Offset: 0x16FCE01 VA: 0x16FCD00 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FCD40 Offset: 0x16FCE41 VA: 0x16FCD40 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


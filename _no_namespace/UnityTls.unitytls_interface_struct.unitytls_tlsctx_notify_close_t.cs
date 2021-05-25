[UnmanagedFunctionPointerAttribute] // RVA: 0xBBBD0 Offset: 0xBBCD1 VA: 0xBBBD0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t : MulticastDelegate // TypeDefIndex: 1677
{
	// Methods

	// RVA: 0x16FBC70 Offset: 0x16FBD71 VA: 0x16FBC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FBC90 Offset: 0x16FBD91 VA: 0x16FBC90 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FBF30 Offset: 0x16FC031 VA: 0x16FBF30 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FBF60 Offset: 0x16FC061 VA: 0x16FBF60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


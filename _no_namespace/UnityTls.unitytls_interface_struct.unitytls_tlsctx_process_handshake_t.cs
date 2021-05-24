[UnmanagedFunctionPointerAttribute] // RVA: 0xBBB70 Offset: 0xBBC71 VA: 0xBBB70
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t : MulticastDelegate // TypeDefIndex: 1674
{
	// Methods

	// RVA: 0x16FBF70 Offset: 0x16FC071 VA: 0x16FBF70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FBF90 Offset: 0x16FC091 VA: 0x16FBF90 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FC240 Offset: 0x16FC341 VA: 0x16FC240 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FC270 Offset: 0x16FC371 VA: 0x16FC270 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}


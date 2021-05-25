[UnmanagedFunctionPointerAttribute] // RVA: 0xBBA70 Offset: 0xBBB71 VA: 0xBBA70
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t : MulticastDelegate // TypeDefIndex: 1666
{
	// Methods

	// RVA: 0x16FA8D0 Offset: 0x16FA9D1 VA: 0x16FA8D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FA8F0 Offset: 0x16FA9F1 VA: 0x16FA8F0 Slot: 13
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FAD10 Offset: 0x16FAE11 VA: 0x16FAD10 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FADF0 Offset: 0x16FAEF1 VA: 0x16FADF0 Slot: 15
	public virtual UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result) { }
}


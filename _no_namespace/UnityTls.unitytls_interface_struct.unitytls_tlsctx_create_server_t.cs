[UnmanagedFunctionPointerAttribute] // RVA: 0xBBA50 Offset: 0xBBB51 VA: 0xBBA50
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t : MulticastDelegate // TypeDefIndex: 1665
{
	// Methods

	// RVA: 0x16FAE00 Offset: 0x16FAF01 VA: 0x16FAE00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FAE20 Offset: 0x16FAF21 VA: 0x16FAE20 Slot: 13
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FB240 Offset: 0x16FB341 VA: 0x16FB240 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FB320 Offset: 0x16FB421 VA: 0x16FB320 Slot: 15
	public virtual UnityTls.unitytls_tlsctx* EndInvoke(IAsyncResult result) { }
}


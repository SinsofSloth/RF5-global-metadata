[UnmanagedFunctionPointerAttribute] // RVA: 0xBBB10 Offset: 0xBBC11 VA: 0xBBB10
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate // TypeDefIndex: 1671
{
	// Methods

	// RVA: 0x16FCD50 Offset: 0x16FCE51 VA: 0x16FCD50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FCD70 Offset: 0x16FCE71 VA: 0x16FCD70 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FD040 Offset: 0x16FD141 VA: 0x16FD040 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FD0F0 Offset: 0x16FD1F1 VA: 0x16FD0F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


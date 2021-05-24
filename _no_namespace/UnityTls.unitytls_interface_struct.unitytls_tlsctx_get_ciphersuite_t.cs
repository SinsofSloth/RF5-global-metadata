[UnmanagedFunctionPointerAttribute] // RVA: 0xBBB30 Offset: 0xBBC31 VA: 0xBBB30
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate // TypeDefIndex: 1672
{
	// Methods

	// RVA: 0x16FB610 Offset: 0x16FB711 VA: 0x16FB610
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FB630 Offset: 0x16FB731 VA: 0x16FB630 Slot: 13
	public virtual UnityTls.unitytls_ciphersuite Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FB8E0 Offset: 0x16FB9E1 VA: 0x16FB8E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FB910 Offset: 0x16FBA11 VA: 0x16FB910 Slot: 15
	public virtual UnityTls.unitytls_ciphersuite EndInvoke(IAsyncResult result) { }
}


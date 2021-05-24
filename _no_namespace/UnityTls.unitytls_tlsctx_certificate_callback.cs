[UnmanagedFunctionPointerAttribute] // RVA: 0xBB830 Offset: 0xBB931 VA: 0xBB830
public sealed class UnityTls.unitytls_tlsctx_certificate_callback : MulticastDelegate // TypeDefIndex: 1646
{
	// Methods

	// RVA: 0x16FF3A0 Offset: 0x16FF4A1 VA: 0x16FF3A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FF3C0 Offset: 0x16FF4C1 VA: 0x16FF3C0 Slot: 13
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FF700 Offset: 0x16FF801 VA: 0x16FF700 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FF7E0 Offset: 0x16FF8E1 VA: 0x16FF7E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


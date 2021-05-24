[UnmanagedFunctionPointerAttribute] // RVA: 0xBBA30 Offset: 0xBBB31 VA: 0xBBA30
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t : MulticastDelegate // TypeDefIndex: 1664
{
	// Methods

	// RVA: 0x16FEF30 Offset: 0x16FF031 VA: 0x16FEF30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FEF50 Offset: 0x16FF051 VA: 0x16FEF50 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FF290 Offset: 0x16FF391 VA: 0x16FF290 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FF370 Offset: 0x16FF471 VA: 0x16FF370 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}


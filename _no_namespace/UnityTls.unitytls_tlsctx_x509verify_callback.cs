[UnmanagedFunctionPointerAttribute] // RVA: 0xBB850 Offset: 0xBB951 VA: 0xBB850
public sealed class UnityTls.unitytls_tlsctx_x509verify_callback : MulticastDelegate // TypeDefIndex: 1647
{
	// Methods

	// RVA: 0x1700360 Offset: 0x1700461 VA: 0x1700360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1700380 Offset: 0x1700481 VA: 0x1700380 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1700640 Offset: 0x1700741 VA: 0x1700640 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x17006E0 Offset: 0x17007E1 VA: 0x17006E0 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}


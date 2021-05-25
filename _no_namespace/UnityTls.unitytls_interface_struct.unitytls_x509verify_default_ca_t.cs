[UnmanagedFunctionPointerAttribute] // RVA: 0xBBA10 Offset: 0xBBB11 VA: 0xBBA10
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t : MulticastDelegate // TypeDefIndex: 1663
{
	// Methods

	// RVA: 0x16FEAE0 Offset: 0x16FEBE1 VA: 0x16FEAE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FEB00 Offset: 0x16FEC01 VA: 0x16FEB00 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FEE30 Offset: 0x16FEF31 VA: 0x16FEE30 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FEF00 Offset: 0x16FF001 VA: 0x16FEF00 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}


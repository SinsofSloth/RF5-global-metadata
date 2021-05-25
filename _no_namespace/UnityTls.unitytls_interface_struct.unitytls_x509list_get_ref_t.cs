[UnmanagedFunctionPointerAttribute] // RVA: 0xBB950 Offset: 0xBBA51 VA: 0xBB950
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t : MulticastDelegate // TypeDefIndex: 1657
{
	// Methods

	// RVA: 0x16FE6B0 Offset: 0x16FE7B1 VA: 0x16FE6B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FE6D0 Offset: 0x16FE7D1 VA: 0x16FE6D0 Slot: 13
	public virtual UnityTls.unitytls_x509list_ref Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FE980 Offset: 0x16FEA81 VA: 0x16FE980 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FE9B0 Offset: 0x16FEAB1 VA: 0x16FE9B0 Slot: 15
	public virtual UnityTls.unitytls_x509list_ref EndInvoke(IAsyncResult result) { }
}


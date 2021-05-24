[UnmanagedFunctionPointerAttribute] // RVA: 0xBB970 Offset: 0xBBA71 VA: 0xBB970
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t : MulticastDelegate // TypeDefIndex: 1658
{
	// Methods

	// RVA: 0x16FE9E0 Offset: 0x16FEAE1 VA: 0x16FE9E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F8930 Offset: 0x16F8A31 VA: 0x16F8930 Slot: 13
	public virtual UnityTls.unitytls_x509_ref Invoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FEA00 Offset: 0x16FEB01 VA: 0x16FEA00 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FEAB0 Offset: 0x16FEBB1 VA: 0x16FEAB0 Slot: 15
	public virtual UnityTls.unitytls_x509_ref EndInvoke(IAsyncResult result) { }
}


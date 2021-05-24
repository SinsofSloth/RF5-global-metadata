[UnmanagedFunctionPointerAttribute] // RVA: 0xBB9B0 Offset: 0xBBAB1 VA: 0xBB9B0
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_t : MulticastDelegate // TypeDefIndex: 1660
{
	// Methods

	// RVA: 0x16FDD50 Offset: 0x16FDE51 VA: 0x16FDD50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FDD70 Offset: 0x16FDE71 VA: 0x16FDD70 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FE030 Offset: 0x16FE131 VA: 0x16FE030 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FE0D0 Offset: 0x16FE1D1 VA: 0x16FE0D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


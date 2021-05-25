[UnmanagedFunctionPointerAttribute] // RVA: 0xBB990 Offset: 0xBBA91 VA: 0xBB990
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_create_t : MulticastDelegate // TypeDefIndex: 1659
{
	// Methods

	// RVA: 0x16FE0E0 Offset: 0x16FE1E1 VA: 0x16FE0E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FE100 Offset: 0x16FE201 VA: 0x16FE100 Slot: 13
	public virtual UnityTls.unitytls_x509list* Invoke(UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FE390 Offset: 0x16FE491 VA: 0x16FE390 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FE3C0 Offset: 0x16FE4C1 VA: 0x16FE3C0 Slot: 15
	public virtual UnityTls.unitytls_x509list* EndInvoke(IAsyncResult result) { }
}


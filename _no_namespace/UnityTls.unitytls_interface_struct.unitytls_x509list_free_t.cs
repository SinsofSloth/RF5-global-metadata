[UnmanagedFunctionPointerAttribute] // RVA: 0xBB9F0 Offset: 0xBBAF1 VA: 0xBB9F0
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_free_t : MulticastDelegate // TypeDefIndex: 1662
{
	// Methods

	// RVA: 0x16FE3D0 Offset: 0x16FE4D1 VA: 0x16FE3D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FE3F0 Offset: 0x16FE4F1 VA: 0x16FE3F0 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_x509list* list) { }

	// RVA: 0x16FE670 Offset: 0x16FE771 VA: 0x16FE670 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, AsyncCallback callback, object object) { }

	// RVA: 0x16FE6A0 Offset: 0x16FE7A1 VA: 0x16FE6A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


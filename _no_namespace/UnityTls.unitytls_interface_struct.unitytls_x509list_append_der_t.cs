[UnmanagedFunctionPointerAttribute] // RVA: 0xBB9D0 Offset: 0xBBAD1 VA: 0xBB9D0
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t : MulticastDelegate // TypeDefIndex: 1661
{
	// Methods

	// RVA: 0x16FDC70 Offset: 0x16FDD71 VA: 0x16FDC70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F83B0 Offset: 0x16F84B1 VA: 0x16F83B0 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FDC90 Offset: 0x16FDD91 VA: 0x16FDC90 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FDD40 Offset: 0x16FDE41 VA: 0x16FDD40 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


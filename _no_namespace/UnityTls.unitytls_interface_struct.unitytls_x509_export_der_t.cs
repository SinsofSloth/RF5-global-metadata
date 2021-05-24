[UnmanagedFunctionPointerAttribute] // RVA: 0xBB930 Offset: 0xBBA31 VA: 0xBB930
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t : MulticastDelegate // TypeDefIndex: 1656
{
	// Methods

	// RVA: 0x16FDB60 Offset: 0x16FDC61 VA: 0x16FDB60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F8C00 Offset: 0x16F8D01 VA: 0x16F8C00 Slot: 13
	public virtual IntPtr Invoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FDB80 Offset: 0x16FDC81 VA: 0x16FDB80 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FDC40 Offset: 0x16FDD41 VA: 0x16FDC40 Slot: 15
	public virtual IntPtr EndInvoke(IAsyncResult result) { }
}


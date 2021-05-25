[UnmanagedFunctionPointerAttribute] // RVA: 0xBB8F0 Offset: 0xBB9F1 VA: 0xBB8F0
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t : MulticastDelegate // TypeDefIndex: 1654
{
	// Methods

	// RVA: 0x16FA150 Offset: 0x16FA251 VA: 0x16FA150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FA170 Offset: 0x16FA271 VA: 0x16FA170 Slot: 13
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FA470 Offset: 0x16FA571 VA: 0x16FA470 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FA530 Offset: 0x16FA631 VA: 0x16FA530 Slot: 15
	public virtual UnityTls.unitytls_key* EndInvoke(IAsyncResult result) { }
}


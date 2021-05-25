[UnmanagedFunctionPointerAttribute] // RVA: 0xBB8D0 Offset: 0xBB9D1 VA: 0xBB8D0
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t : MulticastDelegate // TypeDefIndex: 1653
{
	// Methods

	// RVA: 0x16F9D60 Offset: 0x16F9E61 VA: 0x16F9D60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F9D80 Offset: 0x16F9E81 VA: 0x16F9D80 Slot: 13
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FA080 Offset: 0x16FA181 VA: 0x16FA080 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FA140 Offset: 0x16FA241 VA: 0x16FA140 Slot: 15
	public virtual UnityTls.unitytls_key* EndInvoke(IAsyncResult result) { }
}


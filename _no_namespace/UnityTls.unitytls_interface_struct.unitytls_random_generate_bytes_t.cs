[UnmanagedFunctionPointerAttribute] // RVA: 0xBBC10 Offset: 0xBBD11 VA: 0xBBC10
public sealed class UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t : MulticastDelegate // TypeDefIndex: 1679
{
	// Methods

	// RVA: 0x16FA540 Offset: 0x16FA641 VA: 0x16FA540
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FA560 Offset: 0x16FA661 VA: 0x16FA560 Slot: 13
	public virtual void Invoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FA820 Offset: 0x16FA921 VA: 0x16FA820 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FA8C0 Offset: 0x16FA9C1 VA: 0x16FA8C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


[UnmanagedFunctionPointerAttribute] // RVA: 0xBB8B0 Offset: 0xBB9B1 VA: 0xBB8B0
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t : MulticastDelegate // TypeDefIndex: 1652
{
	// Methods

	// RVA: 0x16F9A30 Offset: 0x16F9B31 VA: 0x16F9A30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F9A50 Offset: 0x16F9B51 VA: 0x16F9A50 Slot: 13
	public virtual UnityTls.unitytls_key_ref Invoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16F9D00 Offset: 0x16F9E01 VA: 0x16F9D00 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16F9D30 Offset: 0x16F9E31 VA: 0x16F9D30 Slot: 15
	public virtual UnityTls.unitytls_key_ref EndInvoke(IAsyncResult result) { }
}


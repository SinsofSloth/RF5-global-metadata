[UnmanagedFunctionPointerAttribute] // RVA: 0xBB910 Offset: 0xBBA11 VA: 0xBB910
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_free_t : MulticastDelegate // TypeDefIndex: 1655
{
	// Methods

	// RVA: 0x16F9750 Offset: 0x16F9851 VA: 0x16F9750
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F9770 Offset: 0x16F9871 VA: 0x16F9770 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_key* key) { }

	// RVA: 0x16F99F0 Offset: 0x16F9AF1 VA: 0x16F99F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_key* key, AsyncCallback callback, object object) { }

	// RVA: 0x16F9A20 Offset: 0x16F9B21 VA: 0x16F9A20 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


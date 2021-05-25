[UnmanagedFunctionPointerAttribute] // RVA: 0xBB890 Offset: 0xBB991 VA: 0xBB890
public sealed class UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t : MulticastDelegate // TypeDefIndex: 1651
{
	// Methods

	// RVA: 0x16F93E0 Offset: 0x16F94E1 VA: 0x16F93E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16F9400 Offset: 0x16F9501 VA: 0x16F9400 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode) { }

	// RVA: 0x16F96A0 Offset: 0x16F97A1 VA: 0x16F96A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode, AsyncCallback callback, object object) { }

	// RVA: 0x16F9740 Offset: 0x16F9841 VA: 0x16F9740 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


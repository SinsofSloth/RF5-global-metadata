[UnmanagedFunctionPointerAttribute] // RVA: 0xBB7B0 Offset: 0xBB8B1 VA: 0xBB7B0
public sealed class UnityTls.unitytls_x509verify_callback : MulticastDelegate // TypeDefIndex: 1637
{
	// Methods

	// RVA: 0x1700710 Offset: 0x1700811 VA: 0x1700710
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1700730 Offset: 0x1700831 VA: 0x1700730 Slot: 13
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1700A10 Offset: 0x1700B11 VA: 0x1700A10 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x1700AD0 Offset: 0x1700BD1 VA: 0x1700AD0 Slot: 15
	public virtual UnityTls.unitytls_x509verify_result EndInvoke(IAsyncResult result) { }
}


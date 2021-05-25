[UnmanagedFunctionPointerAttribute] // RVA: 0xBBA90 Offset: 0xBBB91 VA: 0xBBA90
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate // TypeDefIndex: 1667
{
	// Methods

	// RVA: 0x16FC680 Offset: 0x16FC781 VA: 0x16FC680
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FC6A0 Offset: 0x16FC7A1 VA: 0x16FC6A0 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FC960 Offset: 0x16FCA61 VA: 0x16FC960 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FCA00 Offset: 0x16FCB01 VA: 0x16FCA00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


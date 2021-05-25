[UnmanagedFunctionPointerAttribute] // RVA: 0xBBB50 Offset: 0xBBC51 VA: 0xBBB50
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t : MulticastDelegate // TypeDefIndex: 1673
{
	// Methods

	// RVA: 0x16FB940 Offset: 0x16FBA41 VA: 0x16FB940
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FB960 Offset: 0x16FBA61 VA: 0x16FB960 Slot: 13
	public virtual UnityTls.unitytls_protocol Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x16FBC10 Offset: 0x16FBD11 VA: 0x16FBC10 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState, AsyncCallback callback, object object) { }

	// RVA: 0x16FBC40 Offset: 0x16FBD41 VA: 0x16FBC40 Slot: 15
	public virtual UnityTls.unitytls_protocol EndInvoke(IAsyncResult result) { }
}


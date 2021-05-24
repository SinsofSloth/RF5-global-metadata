[UnmanagedFunctionPointerAttribute] // RVA: 0xBBBF0 Offset: 0xBBCF1 VA: 0xBBBF0
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t : MulticastDelegate // TypeDefIndex: 1678
{
	// Methods

	// RVA: 0x16FB330 Offset: 0x16FB431 VA: 0x16FB330
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FB350 Offset: 0x16FB451 VA: 0x16FB350 Slot: 13
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx) { }

	// RVA: 0x16FB5D0 Offset: 0x16FB6D1 VA: 0x16FB5D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(UnityTls.unitytls_tlsctx* ctx, AsyncCallback callback, object object) { }

	// RVA: 0x16FB600 Offset: 0x16FB701 VA: 0x16FB600 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


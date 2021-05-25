[UnmanagedFunctionPointerAttribute] // RVA: 0xBB810 Offset: 0xBB911 VA: 0xBB810
public sealed class UnityTls.unitytls_tlsctx_trace_callback : MulticastDelegate // TypeDefIndex: 1645
{
	// Methods

	// RVA: 0x16FFBD0 Offset: 0x16FFCD1 VA: 0x16FFBD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16FFBF0 Offset: 0x16FFCF1 VA: 0x16FFBF0 Slot: 13
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen) { }

	// RVA: 0x16FFEC0 Offset: 0x16FFFC1 VA: 0x16FFEC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen, AsyncCallback callback, object object) { }

	// RVA: 0x16FFF70 Offset: 0x1700071 VA: 0x16FFF70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


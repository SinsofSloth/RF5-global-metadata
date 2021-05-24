public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 3314
{
	// Methods

	// RVA: 0x2A1D8F0 Offset: 0x2A1D9F1 VA: 0x2A1D8F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2A1CFF0 Offset: 0x2A1D0F1 VA: 0x2A1CFF0 Slot: 13
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext) { }

	// RVA: 0x2A1D910 Offset: 0x2A1DA11 VA: 0x2A1D910 Slot: 14
	public virtual IAsyncResult BeginInvoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, AsyncCallback callback, object object) { }

	// RVA: 0x2A1D9B0 Offset: 0x2A1DAB1 VA: 0x2A1D9B0 Slot: 15
	public virtual JobHandle EndInvoke(IAsyncResult result) { }
}


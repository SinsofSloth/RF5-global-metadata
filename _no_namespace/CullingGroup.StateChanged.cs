public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 2849
{
	// Methods

	// RVA: 0x2B04BA0 Offset: 0x2B04CA1 VA: 0x2B04BA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2B04900 Offset: 0x2B04A01 VA: 0x2B04900 Slot: 13
	public virtual void Invoke(CullingGroupEvent sphere) { }

	// RVA: 0x2B04BC0 Offset: 0x2B04CC1 VA: 0x2B04BC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(CullingGroupEvent sphere, AsyncCallback callback, object object) { }

	// RVA: 0x2B04C50 Offset: 0x2B04D51 VA: 0x2B04C50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


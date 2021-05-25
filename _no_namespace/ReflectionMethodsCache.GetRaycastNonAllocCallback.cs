public sealed class ReflectionMethodsCache.GetRaycastNonAllocCallback : MulticastDelegate // TypeDefIndex: 4024
{
	// Methods

	// RVA: 0x18C6D40 Offset: 0x18C6E41 VA: 0x18C6D40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18C6D60 Offset: 0x18C6E61 VA: 0x18C6D60 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit[] results, float f, int i) { }

	// RVA: 0x18C7130 Offset: 0x18C7231 VA: 0x18C7130 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18C7200 Offset: 0x18C7301 VA: 0x18C7200 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}


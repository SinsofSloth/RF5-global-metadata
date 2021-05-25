public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 4027
{
	// Methods

	// RVA: 0x18C6850 Offset: 0x18C6951 VA: 0x18C6850
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18C6870 Offset: 0x18C6971 VA: 0x18C6870 Slot: 13
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x18C6C40 Offset: 0x18C6D41 VA: 0x18C6C40 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18C6D10 Offset: 0x18C6E11 VA: 0x18C6D10 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}


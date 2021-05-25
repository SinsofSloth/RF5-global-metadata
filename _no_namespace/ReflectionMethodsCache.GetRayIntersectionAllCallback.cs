public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 4026
{
	// Methods

	// RVA: 0x18C63A0 Offset: 0x18C64A1 VA: 0x18C63A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18C63C0 Offset: 0x18C64C1 VA: 0x18C63C0 Slot: 13
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x18C6770 Offset: 0x18C6871 VA: 0x18C6770 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18C6840 Offset: 0x18C6941 VA: 0x18C6840 Slot: 15
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }
}


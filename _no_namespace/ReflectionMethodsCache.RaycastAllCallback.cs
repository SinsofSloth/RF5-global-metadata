public sealed class ReflectionMethodsCache.RaycastAllCallback : MulticastDelegate // TypeDefIndex: 4023
{
	// Methods

	// RVA: 0x18C7C20 Offset: 0x18C7D21 VA: 0x18C7C20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18C7C40 Offset: 0x18C7D41 VA: 0x18C7C40 Slot: 13
	public virtual RaycastHit[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x18C7FF0 Offset: 0x18C80F1 VA: 0x18C7FF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18C80C0 Offset: 0x18C81C1 VA: 0x18C80C0 Slot: 15
	public virtual RaycastHit[] EndInvoke(IAsyncResult result) { }
}


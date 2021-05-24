public sealed class ReflectionMethodsCache.Raycast3DCallback : MulticastDelegate // TypeDefIndex: 4022
{
	// Methods

	// RVA: 0x18C76F0 Offset: 0x18C77F1 VA: 0x18C76F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18C7710 Offset: 0x18C7811 VA: 0x18C7710 Slot: 13
	public virtual bool Invoke(Ray r, out RaycastHit hit, float f, int i) { }

	// RVA: 0x18C7AF0 Offset: 0x18C7BF1 VA: 0x18C7AF0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x18C7BE0 Offset: 0x18C7CE1 VA: 0x18C7BE0 Slot: 15
	public virtual bool EndInvoke(out RaycastHit hit, IAsyncResult result) { }
}


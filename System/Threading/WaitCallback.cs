[ComVisibleAttribute] // RVA: 0xAF4A0 Offset: 0xAF5A1 VA: 0xAF4A0
public sealed class WaitCallback : MulticastDelegate // TypeDefIndex: 809
{
	// Methods

	// RVA: 0x1576180 Offset: 0x1576281 VA: 0x1576180
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x158F000 Offset: 0x158F101 VA: 0x158F000 Slot: 13
	public virtual void Invoke(object state) { }

	// RVA: 0x158F3D0 Offset: 0x158F4D1 VA: 0x158F3D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	// RVA: 0x158F400 Offset: 0x158F501 VA: 0x158F400 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


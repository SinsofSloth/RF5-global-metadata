[ComVisibleAttribute] // RVA: 0xAF4E0 Offset: 0xAF5E1 VA: 0xAF4E0
public sealed class ThreadStart : MulticastDelegate // TypeDefIndex: 820
{
	// Methods

	// RVA: 0x1589590 Offset: 0x1589691 VA: 0x1589590
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1589D90 Offset: 0x1589E91 VA: 0x1589D90 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x158D100 Offset: 0x158D201 VA: 0x158D100 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x158D130 Offset: 0x158D231 VA: 0x158D130 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


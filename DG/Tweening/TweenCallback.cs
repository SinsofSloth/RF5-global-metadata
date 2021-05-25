public sealed class TweenCallback : MulticastDelegate // TypeDefIndex: 4915
{
	// Methods

	// RVA: 0x1B912C0 Offset: 0x1B913C1 VA: 0x1B912C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B91050 Offset: 0x1B91151 VA: 0x1B91050 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1B912E0 Offset: 0x1B913E1 VA: 0x1B912E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1B91310 Offset: 0x1B91411 VA: 0x1B91310 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


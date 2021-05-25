public sealed class ConcaveColliderInterface.LogDelegate : MulticastDelegate // TypeDefIndex: 9224
{
	// Methods

	// RVA: 0x23A9BB0 Offset: 0x23A9CB1 VA: 0x23A9BB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x23A9C40 Offset: 0x23A9D41 VA: 0x23A9C40 Slot: 13
	public virtual void Invoke(string message) { }

	// RVA: 0x23AA010 Offset: 0x23AA111 VA: 0x23AA010 Slot: 14
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x23AA040 Offset: 0x23AA141 VA: 0x23AA040 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


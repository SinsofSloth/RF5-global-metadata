[ComVisibleAttribute] // RVA: 0xABA90 Offset: 0xABB91 VA: 0xABA90
[Serializable]
public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 183
{
	// Methods

	// RVA: 0x18504E0 Offset: 0x18505E1 VA: 0x18504E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1850500 Offset: 0x1850601 VA: 0x1850500 Slot: 13
	public virtual void Invoke(IAsyncResult ar) { }

	// RVA: 0x18508D0 Offset: 0x18509D1 VA: 0x18508D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	// RVA: 0x1850900 Offset: 0x1850A01 VA: 0x1850900 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


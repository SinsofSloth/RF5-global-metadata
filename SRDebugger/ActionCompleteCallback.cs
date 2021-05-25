public sealed class ActionCompleteCallback : MulticastDelegate // TypeDefIndex: 5532
{
	// Methods

	// RVA: 0x152C9A0 Offset: 0x152CAA1 VA: 0x152C9A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x152C9C0 Offset: 0x152CAC1 VA: 0x152C9C0 Slot: 13
	public virtual void Invoke(bool success) { }

	// RVA: 0x152CC70 Offset: 0x152CD71 VA: 0x152CC70 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool success, AsyncCallback callback, object object) { }

	// RVA: 0x152CD00 Offset: 0x152CE01 VA: 0x152CD00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


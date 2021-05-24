public sealed class SendOrPostCallback : MulticastDelegate // TypeDefIndex: 794
{
	// Methods

	// RVA: 0x1578ED0 Offset: 0x1578FD1 VA: 0x1578ED0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1578EF0 Offset: 0x1578FF1 VA: 0x1578EF0 Slot: 13
	public virtual void Invoke(object state) { }

	// RVA: 0x15792C0 Offset: 0x15793C1 VA: 0x15792C0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	// RVA: 0x15792F0 Offset: 0x15793F1 VA: 0x15792F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


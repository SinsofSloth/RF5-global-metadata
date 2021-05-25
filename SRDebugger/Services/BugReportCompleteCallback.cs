public sealed class BugReportCompleteCallback : MulticastDelegate // TypeDefIndex: 5606
{
	// Methods

	// RVA: 0x15331D0 Offset: 0x15332D1 VA: 0x15331D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15331F0 Offset: 0x15332F1 VA: 0x15331F0 Slot: 13
	public virtual void Invoke(bool didSucceed, string errorMessage) { }

	// RVA: 0x15334B0 Offset: 0x15335B1 VA: 0x15334B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool didSucceed, string errorMessage, AsyncCallback callback, object object) { }

	// RVA: 0x1533550 Offset: 0x1533651 VA: 0x1533550 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


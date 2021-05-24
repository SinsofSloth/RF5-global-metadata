public sealed class BugReportProgressCallback : MulticastDelegate // TypeDefIndex: 5607
{
	// Methods

	// RVA: 0x1533560 Offset: 0x1533661 VA: 0x1533560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1533580 Offset: 0x1533681 VA: 0x1533580 Slot: 13
	public virtual void Invoke(float progress) { }

	// RVA: 0x1533810 Offset: 0x1533911 VA: 0x1533810 Slot: 14
	public virtual IAsyncResult BeginInvoke(float progress, AsyncCallback callback, object object) { }

	// RVA: 0x15338A0 Offset: 0x15339A1 VA: 0x15338A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


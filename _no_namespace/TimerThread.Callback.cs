internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 1921
{
	// Methods

	// RVA: 0x16DED20 Offset: 0x16DEE21 VA: 0x16DED20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x16DED40 Offset: 0x16DEE41 VA: 0x16DED40 Slot: 13
	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x16DF1B0 Offset: 0x16DF2B1 VA: 0x16DF1B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(TimerThread.Timer timer, int timeNoticed, object context, AsyncCallback callback, object object) { }

	// RVA: 0x16DF250 Offset: 0x16DF351 VA: 0x16DF250 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


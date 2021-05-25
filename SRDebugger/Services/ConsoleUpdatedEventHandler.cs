public sealed class ConsoleUpdatedEventHandler : MulticastDelegate // TypeDefIndex: 5609
{
	// Methods

	// RVA: 0x1533C80 Offset: 0x1533D81 VA: 0x1533C80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1533CA0 Offset: 0x1533DA1 VA: 0x1533CA0 Slot: 13
	public virtual void Invoke(IConsoleService console) { }

	// RVA: 0x1534070 Offset: 0x1534171 VA: 0x1534070 Slot: 14
	public virtual IAsyncResult BeginInvoke(IConsoleService console, AsyncCallback callback, object object) { }

	// RVA: 0x15340A0 Offset: 0x15341A1 VA: 0x15340A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


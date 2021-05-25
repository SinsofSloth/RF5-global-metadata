private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 363
{
	// Methods

	// RVA: 0x2979010 Offset: 0x2979111 VA: 0x2979010
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2979030 Offset: 0x2979131 VA: 0x2979030 Slot: 13
	public virtual bool Invoke(int keyCode) { }

	// RVA: 0x29792E0 Offset: 0x29793E1 VA: 0x29792E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0x2979370 Offset: 0x2979471 VA: 0x2979370 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}


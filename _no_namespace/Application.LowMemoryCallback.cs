public sealed class Application.LowMemoryCallback : MulticastDelegate // TypeDefIndex: 2834
{
	// Methods

	// RVA: 0x2AF6DB0 Offset: 0x2AF6EB1 VA: 0x2AF6DB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2AF5D40 Offset: 0x2AF5E41 VA: 0x2AF5D40 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2AF6DD0 Offset: 0x2AF6ED1 VA: 0x2AF6DD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2AF6E00 Offset: 0x2AF6F01 VA: 0x2AF6E00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


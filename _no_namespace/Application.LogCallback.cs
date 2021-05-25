public sealed class Application.LogCallback : MulticastDelegate // TypeDefIndex: 2835
{
	// Methods

	// RVA: 0x2AF6CE0 Offset: 0x2AF6DE1 VA: 0x2AF6CE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2AF61B0 Offset: 0x2AF62B1 VA: 0x2AF61B0 Slot: 13
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }

	// RVA: 0x2AF6D00 Offset: 0x2AF6E01 VA: 0x2AF6D00 Slot: 14
	public virtual IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

	// RVA: 0x2AF6DA0 Offset: 0x2AF6EA1 VA: 0x2AF6DA0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


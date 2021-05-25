public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 3590
{
	// Methods

	// RVA: 0x2D0F5F0 Offset: 0x2D0F6F1 VA: 0x2D0F5F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D0F100 Offset: 0x2D0F201 VA: 0x2D0F100 Slot: 13
	public virtual void Invoke(int id) { }

	// RVA: 0x2D0F610 Offset: 0x2D0F711 VA: 0x2D0F610 Slot: 14
	public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

	// RVA: 0x2D0F6A0 Offset: 0x2D0F7A1 VA: 0x2D0F6A0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


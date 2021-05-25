[ComVisibleAttribute] // RVA: 0xB1210 Offset: 0xB1311 VA: 0xB1210
public sealed class HeaderHandler : MulticastDelegate // TypeDefIndex: 1211
{
	// Methods

	// RVA: 0x1753870 Offset: 0x1753971 VA: 0x1753870
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1753890 Offset: 0x1753991 VA: 0x1753890 Slot: 13
	public virtual object Invoke(Header[] headers) { }

	// RVA: 0x1753C70 Offset: 0x1753D71 VA: 0x1753C70 Slot: 14
	public virtual IAsyncResult BeginInvoke(Header[] headers, AsyncCallback callback, object object) { }

	// RVA: 0x1753CA0 Offset: 0x1753DA1 VA: 0x1753CA0 Slot: 15
	public virtual object EndInvoke(IAsyncResult result) { }
}


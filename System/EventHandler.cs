[ComVisibleAttribute] // RVA: 0xABE90 Offset: 0xABF91 VA: 0xABE90
[Serializable]
public sealed class EventHandler : MulticastDelegate // TypeDefIndex: 226
{
	// Methods

	// RVA: 0x179D4A0 Offset: 0x179D5A1 VA: 0x179D4A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x179D4C0 Offset: 0x179D5C1 VA: 0x179D4C0 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0x179D8E0 Offset: 0x179D9E1 VA: 0x179D8E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x179D910 Offset: 0x179DA11 VA: 0x179D910 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


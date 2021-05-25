[TypeForwardedFromAttribute] // RVA: 0xAB6E0 Offset: 0xAB7E1 VA: 0xAB6E0
public sealed class Action : MulticastDelegate // TypeDefIndex: 153
{
	// Methods

	// RVA: 0x190A630 Offset: 0x190A731 VA: 0x190A630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x190A650 Offset: 0x190A751 VA: 0x190A650 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x190A890 Offset: 0x190A991 VA: 0x190A890 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x190A8C0 Offset: 0x190A9C1 VA: 0x190A8C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


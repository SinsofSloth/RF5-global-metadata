[ComVisibleAttribute] // RVA: 0xACEF0 Offset: 0xACFF1 VA: 0xACEF0
[Serializable]
public sealed class ResolveEventHandler : MulticastDelegate // TypeDefIndex: 398
{
	// Methods

	// RVA: 0x17F3A00 Offset: 0x17F3B01 VA: 0x17F3A00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17F3A20 Offset: 0x17F3B21 VA: 0x17F3A20 Slot: 13
	public virtual Assembly Invoke(object sender, ResolveEventArgs args) { }

	// RVA: 0x17F3E50 Offset: 0x17F3F51 VA: 0x17F3E50 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x17F3E80 Offset: 0x17F3F81 VA: 0x17F3E80 Slot: 15
	public virtual Assembly EndInvoke(IAsyncResult result) { }
}


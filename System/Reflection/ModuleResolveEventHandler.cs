[ComVisibleAttribute] // RVA: 0xAE440 Offset: 0xAE541 VA: 0xAE440
[Serializable]
public sealed class ModuleResolveEventHandler : MulticastDelegate // TypeDefIndex: 584
{
	// Methods

	// RVA: 0x196B6C0 Offset: 0x196B7C1 VA: 0x196B6C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x196B6E0 Offset: 0x196B7E1 VA: 0x196B6E0 Slot: 13
	public virtual Module Invoke(object sender, ResolveEventArgs e) { }

	// RVA: 0x196BB10 Offset: 0x196BC11 VA: 0x196BB10 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ResolveEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x196BB40 Offset: 0x196BC41 VA: 0x196BB40 Slot: 15
	public virtual Module EndInvoke(IAsyncResult result) { }
}


internal sealed class NativeUpdateCallback : MulticastDelegate // TypeDefIndex: 3808
{
	// Methods

	// RVA: 0x1BE2960 Offset: 0x1BE2A61 VA: 0x1BE2960
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BE2530 Offset: 0x1BE2631 VA: 0x1BE2530 Slot: 13
	public virtual void Invoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer) { }

	// RVA: 0x1BE2980 Offset: 0x1BE2A81 VA: 0x1BE2980 Slot: 14
	public virtual IAsyncResult BeginInvoke(NativeInputUpdateType updateType, NativeInputEventBuffer* buffer, AsyncCallback callback, object object) { }

	// RVA: 0x1BE2A20 Offset: 0x1BE2B21 VA: 0x1BE2A20 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


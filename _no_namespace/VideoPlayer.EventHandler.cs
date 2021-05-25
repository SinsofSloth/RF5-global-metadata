public sealed class VideoPlayer.EventHandler : MulticastDelegate // TypeDefIndex: 4281
{
	// Methods

	// RVA: 0x1BD8630 Offset: 0x1BD8731 VA: 0x1BD8630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BD73E0 Offset: 0x1BD74E1 VA: 0x1BD73E0 Slot: 13
	public virtual void Invoke(VideoPlayer source) { }

	// RVA: 0x1BD8650 Offset: 0x1BD8751 VA: 0x1BD8650 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, AsyncCallback callback, object object) { }

	// RVA: 0x1BD8680 Offset: 0x1BD8781 VA: 0x1BD8680 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


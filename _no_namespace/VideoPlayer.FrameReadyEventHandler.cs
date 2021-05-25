public sealed class VideoPlayer.FrameReadyEventHandler : MulticastDelegate // TypeDefIndex: 4283
{
	// Methods

	// RVA: 0x1BD8690 Offset: 0x1BD8791 VA: 0x1BD8690
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BD77E0 Offset: 0x1BD78E1 VA: 0x1BD77E0 Slot: 13
	public virtual void Invoke(VideoPlayer source, long frameIdx) { }

	// RVA: 0x1BD86B0 Offset: 0x1BD87B1 VA: 0x1BD86B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, long frameIdx, AsyncCallback callback, object object) { }

	// RVA: 0x1BD8750 Offset: 0x1BD8851 VA: 0x1BD8750 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


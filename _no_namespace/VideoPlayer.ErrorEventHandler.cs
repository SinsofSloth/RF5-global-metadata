public sealed class VideoPlayer.ErrorEventHandler : MulticastDelegate // TypeDefIndex: 4282
{
	// Methods

	// RVA: 0x1BD85D0 Offset: 0x1BD86D1 VA: 0x1BD85D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BD7D00 Offset: 0x1BD7E01 VA: 0x1BD7D00 Slot: 13
	public virtual void Invoke(VideoPlayer source, string message) { }

	// RVA: 0x1BD85F0 Offset: 0x1BD86F1 VA: 0x1BD85F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, string message, AsyncCallback callback, object object) { }

	// RVA: 0x1BD8620 Offset: 0x1BD8721 VA: 0x1BD8620 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


public sealed class VideoPlayer.TimeEventHandler : MulticastDelegate // TypeDefIndex: 4284
{
	// Methods

	// RVA: 0x1BD8760 Offset: 0x1BD8861 VA: 0x1BD8760
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BD8180 Offset: 0x1BD8281 VA: 0x1BD8180 Slot: 13
	public virtual void Invoke(VideoPlayer source, double seconds) { }

	// RVA: 0x1BD8780 Offset: 0x1BD8881 VA: 0x1BD8780 Slot: 14
	public virtual IAsyncResult BeginInvoke(VideoPlayer source, double seconds, AsyncCallback callback, object object) { }

	// RVA: 0x1BD8820 Offset: 0x1BD8921 VA: 0x1BD8820 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


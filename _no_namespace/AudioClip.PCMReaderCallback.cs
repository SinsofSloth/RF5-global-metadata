public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 3564
{
	// Methods

	// RVA: 0x1BB3A50 Offset: 0x1BB3B51 VA: 0x1BB3A50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BB33D0 Offset: 0x1BB34D1 VA: 0x1BB33D0 Slot: 13
	public virtual void Invoke(float[] data) { }

	// RVA: 0x1BB3A70 Offset: 0x1BB3B71 VA: 0x1BB3A70 Slot: 14
	public virtual IAsyncResult BeginInvoke(float[] data, AsyncCallback callback, object object) { }

	// RVA: 0x1BB3AA0 Offset: 0x1BB3BA1 VA: 0x1BB3AA0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


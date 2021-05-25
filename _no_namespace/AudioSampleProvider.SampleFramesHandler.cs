public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 3579
{
	// Methods

	// RVA: 0x1BB6C00 Offset: 0x1BB6D01 VA: 0x1BB6C00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BB6770 Offset: 0x1BB6871 VA: 0x1BB6770 Slot: 13
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	// RVA: 0x1BB6C20 Offset: 0x1BB6D21 VA: 0x1BB6C20 Slot: 14
	public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, object object) { }

	// RVA: 0x1BB6CC0 Offset: 0x1BB6DC1 VA: 0x1BB6CC0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


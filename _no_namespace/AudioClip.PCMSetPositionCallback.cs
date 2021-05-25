public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 3565
{
	// Methods

	// RVA: 0x1BB3AB0 Offset: 0x1BB3BB1 VA: 0x1BB3AB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BB37B0 Offset: 0x1BB38B1 VA: 0x1BB37B0 Slot: 13
	public virtual void Invoke(int position) { }

	// RVA: 0x1BB3AD0 Offset: 0x1BB3BD1 VA: 0x1BB3AD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int position, AsyncCallback callback, object object) { }

	// RVA: 0x1BB3B60 Offset: 0x1BB3C61 VA: 0x1BB3B60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


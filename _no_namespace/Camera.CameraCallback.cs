public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 2845
{
	// Methods

	// RVA: 0x2AFFF90 Offset: 0x2B00091 VA: 0x2AFFF90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2AFF920 Offset: 0x2AFFA21 VA: 0x2AFF920 Slot: 13
	public virtual void Invoke(Camera cam) { }

	// RVA: 0x2AFFFB0 Offset: 0x2B000B1 VA: 0x2AFFFB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Camera cam, AsyncCallback callback, object object) { }

	// RVA: 0x2AFFFE0 Offset: 0x2B000E1 VA: 0x2AFFFE0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


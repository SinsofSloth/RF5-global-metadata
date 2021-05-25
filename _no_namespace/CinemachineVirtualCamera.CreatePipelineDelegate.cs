public sealed class CinemachineVirtualCamera.CreatePipelineDelegate : MulticastDelegate // TypeDefIndex: 4779
{
	// Methods

	// RVA: 0x1A1CA20 Offset: 0x1A1CB21 VA: 0x1A1CA20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1AAB0 Offset: 0x1A1ABB1 VA: 0x1A1AAB0 Slot: 13
	public virtual Transform Invoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom) { }

	// RVA: 0x1A1CA40 Offset: 0x1A1CB41 VA: 0x1A1CA40 Slot: 14
	public virtual IAsyncResult BeginInvoke(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom, AsyncCallback callback, object object) { }

	// RVA: 0x1A1CA70 Offset: 0x1A1CB71 VA: 0x1A1CA70 Slot: 15
	public virtual Transform EndInvoke(IAsyncResult result) { }
}


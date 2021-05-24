public sealed class CinemachineFreeLook.CreateRigDelegate : MulticastDelegate // TypeDefIndex: 4756
{
	// Methods

	// RVA: 0x1729C50 Offset: 0x1729D51 VA: 0x1729C50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1728260 Offset: 0x1728361 VA: 0x1728260 Slot: 13
	public virtual CinemachineVirtualCamera Invoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1729C70 Offset: 0x1729D71 VA: 0x1729C70 Slot: 14
	public virtual IAsyncResult BeginInvoke(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom, AsyncCallback callback, object object) { }

	// RVA: 0x1729CA0 Offset: 0x1729DA1 VA: 0x1729CA0 Slot: 15
	public virtual CinemachineVirtualCamera EndInvoke(IAsyncResult result) { }
}


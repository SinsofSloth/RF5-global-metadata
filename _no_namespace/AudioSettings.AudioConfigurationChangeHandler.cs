public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 3562
{
	// Methods

	// RVA: 0x1BB4490 Offset: 0x1BB4591 VA: 0x1BB4490
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BB41E0 Offset: 0x1BB42E1 VA: 0x1BB41E0 Slot: 13
	public virtual void Invoke(bool deviceWasChanged) { }

	// RVA: 0x1BB44B0 Offset: 0x1BB45B1 VA: 0x1BB44B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

	// RVA: 0x1BB4540 Offset: 0x1BB4641 VA: 0x1BB4540 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


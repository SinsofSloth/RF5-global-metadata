public sealed class VisibilityChangedDelegate : MulticastDelegate // TypeDefIndex: 5531
{
	// Methods

	// RVA: 0x1B38030 Offset: 0x1B38131 VA: 0x1B38030
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B38050 Offset: 0x1B38151 VA: 0x1B38050 Slot: 13
	public virtual void Invoke(bool isVisible) { }

	// RVA: 0x1B38300 Offset: 0x1B38401 VA: 0x1B38300 Slot: 14
	public virtual IAsyncResult BeginInvoke(bool isVisible, AsyncCallback callback, object object) { }

	// RVA: 0x1B38390 Offset: 0x1B38491 VA: 0x1B38390 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


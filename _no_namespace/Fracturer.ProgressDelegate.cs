public sealed class Fracturer.ProgressDelegate : MulticastDelegate // TypeDefIndex: 9227
{
	// Methods

	// RVA: 0x1F4A3A0 Offset: 0x1F4A4A1 VA: 0x1F4A3A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F4A3C0 Offset: 0x1F4A4C1 VA: 0x1F4A3C0 Slot: 13
	public virtual void Invoke(string strTitle, string message, float fT) { }

	// RVA: 0x1F4A810 Offset: 0x1F4A911 VA: 0x1F4A810 Slot: 14
	public virtual IAsyncResult BeginInvoke(string strTitle, string message, float fT, AsyncCallback callback, object object) { }

	// RVA: 0x1F4A8B0 Offset: 0x1F4A9B1 VA: 0x1F4A8B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


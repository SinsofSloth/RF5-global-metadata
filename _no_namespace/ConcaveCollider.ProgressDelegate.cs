public sealed class ConcaveCollider.ProgressDelegate : MulticastDelegate // TypeDefIndex: 9018
{
	// Methods

	// RVA: 0x1FC9580 Offset: 0x1FC9681 VA: 0x1FC9580
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FC95A0 Offset: 0x1FC96A1 VA: 0x1FC95A0 Slot: 13
	public virtual void Invoke(string message, float fPercent) { }

	// RVA: 0x1FC99E0 Offset: 0x1FC9AE1 VA: 0x1FC99E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string message, float fPercent, AsyncCallback callback, object object) { }

	// RVA: 0x1FC9A80 Offset: 0x1FC9B81 VA: 0x1FC9A80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


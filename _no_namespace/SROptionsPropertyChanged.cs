public sealed class SROptionsPropertyChanged : MulticastDelegate // TypeDefIndex: 8965
{
	// Methods

	// RVA: 0x1D6D4D0 Offset: 0x1D6D5D1 VA: 0x1D6D4D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D6CCC0 Offset: 0x1D6CDC1 VA: 0x1D6CCC0 Slot: 13
	public virtual void Invoke(object sender, string propertyName) { }

	// RVA: 0x1D6D4F0 Offset: 0x1D6D5F1 VA: 0x1D6D4F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, string propertyName, AsyncCallback callback, object object) { }

	// RVA: 0x1D6D520 Offset: 0x1D6D621 VA: 0x1D6D520 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


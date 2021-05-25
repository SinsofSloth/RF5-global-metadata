public sealed class PropertyChangedEventHandler : MulticastDelegate // TypeDefIndex: 1813
{
	// Methods

	// RVA: 0x28E7CE0 Offset: 0x28E7DE1 VA: 0x28E7CE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x28E7D00 Offset: 0x28E7E01 VA: 0x28E7D00 Slot: 13
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }

	// RVA: 0x28E8120 Offset: 0x28E8221 VA: 0x28E8120 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x28E8150 Offset: 0x28E8251 VA: 0x28E8150 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


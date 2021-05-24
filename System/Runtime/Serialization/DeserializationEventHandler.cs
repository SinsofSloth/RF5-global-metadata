[Serializable]
internal sealed class DeserializationEventHandler : MulticastDelegate // TypeDefIndex: 996
{
	// Methods

	// RVA: 0x15FD670 Offset: 0x15FD771 VA: 0x15FD670
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15FD690 Offset: 0x15FD791 VA: 0x15FD690 Slot: 13
	public virtual void Invoke(object sender) { }

	// RVA: 0x15FDA60 Offset: 0x15FDB61 VA: 0x15FDA60 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, AsyncCallback callback, object object) { }

	// RVA: 0x15FDA90 Offset: 0x15FDB91 VA: 0x15FDA90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


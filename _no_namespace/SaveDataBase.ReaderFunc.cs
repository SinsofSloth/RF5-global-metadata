protected sealed class SaveDataBase.ReaderFunc : MulticastDelegate // TypeDefIndex: 9911
{
	// Methods

	// RVA: 0x20F77B0 Offset: 0x20F78B1 VA: 0x20F77B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x20F73E0 Offset: 0x20F74E1 VA: 0x20F73E0 Slot: 13
	public virtual void Invoke(BinaryReader reader) { }

	// RVA: 0x20F77D0 Offset: 0x20F78D1 VA: 0x20F77D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(BinaryReader reader, AsyncCallback callback, object object) { }

	// RVA: 0x20F7800 Offset: 0x20F7901 VA: 0x20F7800 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


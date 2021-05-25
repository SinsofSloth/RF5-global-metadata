public sealed class CombinedMesh.CombineProgressDelegate : MulticastDelegate // TypeDefIndex: 9040
{
	// Methods

	// RVA: 0x1FC4590 Offset: 0x1FC4691 VA: 0x1FC4590
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1FC3D20 Offset: 0x1FC3E21 VA: 0x1FC3D20 Slot: 13
	public virtual void Invoke(string strMessage, float fT) { }

	// RVA: 0x1FC45B0 Offset: 0x1FC46B1 VA: 0x1FC45B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string strMessage, float fT, AsyncCallback callback, object object) { }

	// RVA: 0x1FC4650 Offset: 0x1FC4751 VA: 0x1FC4650 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


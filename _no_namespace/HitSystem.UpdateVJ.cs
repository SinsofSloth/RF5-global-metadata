private sealed class HitSystem.UpdateVJ : MulticastDelegate // TypeDefIndex: 7622
{
	// Methods

	// RVA: 0x1E7F5D0 Offset: 0x1E7F6D1 VA: 0x1E7F5D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E7F5F0 Offset: 0x1E7F6F1 VA: 0x1E7F5F0 Slot: 13
	public virtual bool Invoke(HitUnit unit, float time) { }

	// RVA: 0x1E7FA40 Offset: 0x1E7FB41 VA: 0x1E7FA40 Slot: 14
	public virtual IAsyncResult BeginInvoke(HitUnit unit, float time, AsyncCallback callback, object object) { }

	// RVA: 0x1E7FAE0 Offset: 0x1E7FBE1 VA: 0x1E7FAE0 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}


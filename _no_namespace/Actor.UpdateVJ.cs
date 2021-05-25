private sealed class Actor.UpdateVJ : MulticastDelegate // TypeDefIndex: 6301
{
	// Methods

	// RVA: 0x1BE8CA0 Offset: 0x1BE8DA1 VA: 0x1BE8CA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BE7640 Offset: 0x1BE7741 VA: 0x1BE7640 Slot: 13
	public virtual void Invoke(Actor actor) { }

	// RVA: 0x1BE8CC0 Offset: 0x1BE8DC1 VA: 0x1BE8CC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Actor actor, AsyncCallback callback, object object) { }

	// RVA: 0x1BE8CF0 Offset: 0x1BE8DF1 VA: 0x1BE8CF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


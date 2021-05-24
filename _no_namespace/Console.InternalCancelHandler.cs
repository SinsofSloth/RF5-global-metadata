private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 364
{
	// Methods

	// RVA: 0x2977650 Offset: 0x2977751 VA: 0x2977650
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2978B90 Offset: 0x2978C91 VA: 0x2978B90 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2978DD0 Offset: 0x2978ED1 VA: 0x2978DD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2978E00 Offset: 0x2978F01 VA: 0x2978E00 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


public sealed class ConsoleCancelEventHandler : MulticastDelegate // TypeDefIndex: 196
{
	// Methods

	// RVA: 0x29793F0 Offset: 0x29794F1 VA: 0x29793F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2978770 Offset: 0x2978871 VA: 0x2978770 Slot: 13
	public virtual void Invoke(object sender, ConsoleCancelEventArgs e) { }

	// RVA: 0x2979410 Offset: 0x2979511 VA: 0x2979410 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, ConsoleCancelEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x2979440 Offset: 0x2979541 VA: 0x2979440 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


[ComVisibleAttribute] // RVA: 0xACC30 Offset: 0xACD31 VA: 0xACC30
[Serializable]
public sealed class UnhandledExceptionEventHandler : MulticastDelegate // TypeDefIndex: 341
{
	// Methods

	// RVA: 0x1AE3F50 Offset: 0x1AE4051 VA: 0x1AE3F50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1AE3F70 Offset: 0x1AE4071 VA: 0x1AE3F70 Slot: 13
	public virtual void Invoke(object sender, UnhandledExceptionEventArgs e) { }

	// RVA: 0x1AE4390 Offset: 0x1AE4491 VA: 0x1AE4390 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, UnhandledExceptionEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x1AE43C0 Offset: 0x1AE44C1 VA: 0x1AE43C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


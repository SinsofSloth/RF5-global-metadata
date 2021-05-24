[ComVisibleAttribute] // RVA: 0xAF300 Offset: 0xAF401 VA: 0xAF300
public sealed class ParameterizedThreadStart : MulticastDelegate // TypeDefIndex: 792
{
	// Methods

	// RVA: 0x1A127D0 Offset: 0x1A128D1 VA: 0x1A127D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A127F0 Offset: 0x1A128F1 VA: 0x1A127F0 Slot: 13
	public virtual void Invoke(object obj) { }

	// RVA: 0x1A12BC0 Offset: 0x1A12CC1 VA: 0x1A12BC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object obj, AsyncCallback callback, object object) { }

	// RVA: 0x1A12BF0 Offset: 0x1A12CF1 VA: 0x1A12BF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


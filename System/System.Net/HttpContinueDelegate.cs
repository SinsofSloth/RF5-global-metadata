public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 1893
{
	// Methods

	// RVA: 0x178BF80 Offset: 0x178C081 VA: 0x178BF80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x178BFA0 Offset: 0x178C0A1 VA: 0x178BFA0 Slot: 13
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }

	// RVA: 0x178C250 Offset: 0x178C351 VA: 0x178C250 Slot: 14
	public virtual IAsyncResult BeginInvoke(int StatusCode, WebHeaderCollection httpHeaders, AsyncCallback callback, object object) { }

	// RVA: 0x178C2F0 Offset: 0x178C3F1 VA: 0x178C2F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


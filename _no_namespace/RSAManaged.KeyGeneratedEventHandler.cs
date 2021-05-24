public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 72
{
	// Methods

	// RVA: 0x18F90F0 Offset: 0x18F91F1 VA: 0x18F90F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18F7450 Offset: 0x18F7551 VA: 0x18F7450 Slot: 13
	public virtual void Invoke(object sender, EventArgs e) { }

	// RVA: 0x18F9110 Offset: 0x18F9211 VA: 0x18F9110 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, EventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x18F9140 Offset: 0x18F9241 VA: 0x18F9140 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


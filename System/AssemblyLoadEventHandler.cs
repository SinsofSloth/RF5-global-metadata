[ComVisibleAttribute] // RVA: 0xACD60 Offset: 0xACE61 VA: 0xACD60
[Serializable]
public sealed class AssemblyLoadEventHandler : MulticastDelegate // TypeDefIndex: 360
{
	// Methods

	// RVA: 0x1850480 Offset: 0x1850581 VA: 0x1850480
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1846BB0 Offset: 0x1846CB1 VA: 0x1846BB0 Slot: 13
	public virtual void Invoke(object sender, AssemblyLoadEventArgs args) { }

	// RVA: 0x18504A0 Offset: 0x18505A1 VA: 0x18504A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object sender, AssemblyLoadEventArgs args, AsyncCallback callback, object object) { }

	// RVA: 0x18504D0 Offset: 0x18505D1 VA: 0x18504D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


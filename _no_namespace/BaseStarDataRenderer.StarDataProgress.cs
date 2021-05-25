public sealed class BaseStarDataRenderer.StarDataProgress : MulticastDelegate // TypeDefIndex: 8981
{
	// Methods

	// RVA: 0x215D4C0 Offset: 0x215D5C1 VA: 0x215D4C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x215CB20 Offset: 0x215CC21 VA: 0x215CB20 Slot: 13
	public virtual void Invoke(BaseStarDataRenderer renderer, float progress) { }

	// RVA: 0x215D4E0 Offset: 0x215D5E1 VA: 0x215D4E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(BaseStarDataRenderer renderer, float progress, AsyncCallback callback, object object) { }

	// RVA: 0x215D580 Offset: 0x215D681 VA: 0x215D580 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


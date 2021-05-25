public sealed class BaseStarDataRenderer.StarDataComplete : MulticastDelegate // TypeDefIndex: 8982
{
	// Methods

	// RVA: 0x215D3E0 Offset: 0x215D4E1 VA: 0x215D3E0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x215CF80 Offset: 0x215D081 VA: 0x215CF80 Slot: 13
	public virtual void Invoke(BaseStarDataRenderer renderer, Texture2D texture, bool success) { }

	// RVA: 0x215D400 Offset: 0x215D501 VA: 0x215D400 Slot: 14
	public virtual IAsyncResult BeginInvoke(BaseStarDataRenderer renderer, Texture2D texture, bool success, AsyncCallback callback, object object) { }

	// RVA: 0x215D4B0 Offset: 0x215D5B1 VA: 0x215D4B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


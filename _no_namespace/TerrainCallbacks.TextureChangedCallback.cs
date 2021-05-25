public sealed class TerrainCallbacks.TextureChangedCallback : MulticastDelegate // TypeDefIndex: 3666
{
	// Methods

	// RVA: 0x1B46C90 Offset: 0x1B46D91 VA: 0x1B46C90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B466F0 Offset: 0x1B467F1 VA: 0x1B466F0 Slot: 13
	public virtual void Invoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched) { }

	// RVA: 0x1B46CB0 Offset: 0x1B46DB1 VA: 0x1B46CB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Terrain terrain, string textureName, RectInt texelRegion, bool synched, AsyncCallback callback, object object) { }

	// RVA: 0x1B46D70 Offset: 0x1B46E71 VA: 0x1B46D70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


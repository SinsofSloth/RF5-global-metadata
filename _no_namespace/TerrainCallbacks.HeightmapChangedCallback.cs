public sealed class TerrainCallbacks.HeightmapChangedCallback : MulticastDelegate // TypeDefIndex: 3665
{
	// Methods

	// RVA: 0x1B46BA0 Offset: 0x1B46CA1 VA: 0x1B46BA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B46130 Offset: 0x1B46231 VA: 0x1B46130 Slot: 13
	public virtual void Invoke(Terrain terrain, RectInt heightRegion, bool synched) { }

	// RVA: 0x1B46BC0 Offset: 0x1B46CC1 VA: 0x1B46BC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(Terrain terrain, RectInt heightRegion, bool synched, AsyncCallback callback, object object) { }

	// RVA: 0x1B46C80 Offset: 0x1B46D81 VA: 0x1B46C80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}


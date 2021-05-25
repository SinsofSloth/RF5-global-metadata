public sealed class TerrainUtility.TerrainMap.TerrainFilter : MulticastDelegate // TypeDefIndex: 3669
{
	// Methods

	// RVA: 0x1B47440 Offset: 0x1B47541 VA: 0x1B47440
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B48410 Offset: 0x1B48511 VA: 0x1B48410 Slot: 13
	public virtual bool Invoke(Terrain terrain) { }

	// RVA: 0x1B49530 Offset: 0x1B49631 VA: 0x1B49530 Slot: 14
	public virtual IAsyncResult BeginInvoke(Terrain terrain, AsyncCallback callback, object object) { }

	// RVA: 0x1B49560 Offset: 0x1B49661 VA: 0x1B49560 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}


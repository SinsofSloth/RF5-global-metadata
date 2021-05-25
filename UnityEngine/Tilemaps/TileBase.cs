[RequiredByNativeCodeAttribute] // RVA: 0x1185D0 Offset: 0x1186D1 VA: 0x1185D0
public abstract class TileBase : ScriptableObject // TypeDefIndex: 3895
{
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x118970 Offset: 0x118A71 VA: 0x118970
	// RVA: 0x1BE0380 Offset: 0x1BE0481 VA: 0x1BE0380 Slot: 4
	public virtual void RefreshTile(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x118980 Offset: 0x118A81 VA: 0x118980
	// RVA: 0x1BE03F0 Offset: 0x1BE04F1 VA: 0x1BE03F0 Slot: 5
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	// RVA: 0x1BE0400 Offset: 0x1BE0501 VA: 0x1BE0400
	private TileData GetTileDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x118990 Offset: 0x118A91 VA: 0x118990
	// RVA: 0x1BE0490 Offset: 0x1BE0591 VA: 0x1BE0490 Slot: 6
	public virtual bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData) { }

	// RVA: 0x1BE04A0 Offset: 0x1BE05A1 VA: 0x1BE04A0
	private TileAnimationData GetTileAnimationDataNoRef(Vector3Int position, ITilemap tilemap) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x1189A0 Offset: 0x118AA1 VA: 0x1189A0
	// RVA: 0x1BE04E0 Offset: 0x1BE05E1 VA: 0x1BE04E0 Slot: 7
	public virtual bool StartUp(Vector3Int position, ITilemap tilemap, GameObject go) { }

	// RVA: 0x1BE0370 Offset: 0x1BE0471 VA: 0x1BE0370
	protected void .ctor() { }
}


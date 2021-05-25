[Serializable]
public struct FieldItemSpawnDataTable // TypeDefIndex: 10489
{
	// Fields
	public FieldItemSpawnID DataID; // 0x0
	public ItemID ItemId; // 0x4
	public int Amount; // 0x8
	public int Level; // 0xC
	public int SpawnType; // 0x10
	public int RespawnType; // 0x14
	public int SeasonBit; // 0x18
	public int SpawnRatio; // 0x1C
	public FieldSceneId FieldId; // 0x20

	// Methods

	// RVA: 0x2E0860 Offset: 0x2E0961 VA: 0x2E0860
	public int[] GetLevelAmount() { }

	// RVA: 0x2E0900 Offset: 0x2E0A01 VA: 0x2E0900
	public bool CanSpawnSeason(Season season) { }
}


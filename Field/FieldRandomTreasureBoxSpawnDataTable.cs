[Serializable]
public struct FieldRandomTreasureBoxSpawnDataTable // TypeDefIndex: 10525
{
	// Fields
	public FieldRandomTreasureBoxSpawnID DataID; // 0x0
	public int BoxType; // 0x4
	public int SpawnRatio; // 0x8
	public int[] Ratios; // 0x10
	public int SeasonBit; // 0x18
	public FieldSceneId FieldId; // 0x1C

	// Methods

	// RVA: 0x2E0A50 Offset: 0x2E0B51 VA: 0x2E0A50
	public int GetRatiosLength() { }

	// RVA: 0x2E0A70 Offset: 0x2E0B71 VA: 0x2E0A70
	public bool IsRespawn() { }

	// RVA: 0x2E0A80 Offset: 0x2E0B81 VA: 0x2E0A80
	public bool IsTakeDamege() { }
}


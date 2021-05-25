[Serializable]
public struct MiningPointSaveData // TypeDefIndex: 7445
{
	// Fields
	public FarmManager.FARM_ID FarmId; // 0x0
	public int UID; // 0x4
	public Vector3 Position; // 0x8
	public CropID CropId; // 0x14
	public MineTypeID MineTypeId; // 0x18
	public ItemID ItemId; // 0x1C
	public int HP; // 0x20

	// Methods

	// RVA: 0x2DE960 Offset: 0x2DEA61 VA: 0x2DE960
	public void .ctor(MiningPoint mp) { }

	// RVA: 0x2DE9E0 Offset: 0x2DEAE1 VA: 0x2DE9E0
	public void .ctor(FarmManager.FARM_ID farmId, int uid, Vector3 position, CropID cropId, MineTypeID mineTypeId, ItemID itemId, int hp) { }
}


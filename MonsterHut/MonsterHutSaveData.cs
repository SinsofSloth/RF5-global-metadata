[MessagePackObjectAttribute] // RVA: 0x149CC0 Offset: 0x149DC1 VA: 0x149CC0
public struct MonsterHutSaveData // TypeDefIndex: 9938
{
	// Fields
	[KeyAttribute] // RVA: 0x17FB50 Offset: 0x17FC51 VA: 0x17FB50
	public FarmManager.FARM_ID FarmId; // 0x0
	[KeyAttribute] // RVA: 0x17FB70 Offset: 0x17FC71 VA: 0x17FB70
	public bool MonsterHutReleaseState; // 0x4
	[KeyAttribute] // RVA: 0x17FB90 Offset: 0x17FC91 VA: 0x17FB90
	public int MonsterHutPlaceId; // 0x8
	[KeyAttribute] // RVA: 0x17FBB0 Offset: 0x17FCB1 VA: 0x17FBB0
	public int AreaReleaseState; // 0xC
	[KeyAttribute] // RVA: 0x17FBD0 Offset: 0x17FCD1 VA: 0x17FBD0
	public FriendMonsterIDAndHouseID[] MonsterIds; // 0x10
	[KeyAttribute] // RVA: 0x17FBF0 Offset: 0x17FCF1 VA: 0x17FBF0
	public ItemID[] YieldItems; // 0x18
	[KeyAttribute] // RVA: 0x17FC10 Offset: 0x17FD11 VA: 0x17FC10
	public int[] YieldLevels; // 0x20

	// Methods

	// RVA: 0x2E2CF0 Offset: 0x2E2DF1 VA: 0x2E2CF0
	public void .ctor(MonsterHutController mhc) { }

	// RVA: 0x2E2D00 Offset: 0x2E2E01 VA: 0x2E2D00
	public void .ctor(FarmManager.FARM_ID farmId, int monsterHutPlaceId, int areaReleaseState) { }

	[SerializationConstructorAttribute] // RVA: 0x1AD5E0 Offset: 0x1AD6E1 VA: 0x1AD5E0
	// RVA: 0x2E2D10 Offset: 0x2E2E11 VA: 0x2E2D10
	public void .ctor(FarmManager.FARM_ID farmId, bool monsterHutReleaseState, int monsterHutPlaceId, int areaReleaseState, FriendMonsterIDAndHouseID[] monsterIds, ItemID[] yieldItems, int[] yieldLevels) { }
}


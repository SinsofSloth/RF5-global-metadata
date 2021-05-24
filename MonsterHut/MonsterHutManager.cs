public class MonsterHutManager : SingletonMonoBehaviour<MonsterHutManager> // TypeDefIndex: 9939
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x17FC30 Offset: 0x17FD31 VA: 0x17FC30
	private MonsterHutController <activeMonsterHutController>k__BackingField; // 0x18
	private List<MonsterHutSaveData> _monsterHutSaveDatas; // 0x20
	private FarmManager.FARM_ID activeFarmId; // 0x28
	private int monsterHutPlaceID; // 0x2C

	// Properties
	public MonsterHutController activeMonsterHutController { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD5F0 Offset: 0x1AD6F1 VA: 0x1AD5F0
	// RVA: 0x21767B0 Offset: 0x21768B1 VA: 0x21767B0
	public MonsterHutController get_activeMonsterHutController() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD600 Offset: 0x1AD701 VA: 0x1AD600
	// RVA: 0x21767C0 Offset: 0x21768C1 VA: 0x21767C0
	private void set_activeMonsterHutController(MonsterHutController value) { }

	// RVA: 0x21767D0 Offset: 0x21768D1 VA: 0x21767D0
	public void OnAfterGameDataLoad() { }

	// RVA: 0x2173A00 Offset: 0x2173B01 VA: 0x2173A00
	public void SetAccessMonsterHut(FarmManager.FARM_ID farmId, int monsterHutPlaceId) { }

	// RVA: 0x21766E0 Offset: 0x21767E1 VA: 0x21766E0
	public void SetMonsterHutController(MonsterHutController monsterHutController) { }

	// RVA: 0x2176190 Offset: 0x2176291 VA: 0x2176190
	public void ResetMonsterHutController() { }

	// RVA: 0x2174480 Offset: 0x2174581 VA: 0x2174480
	public MonsterHutSaveData GetMonsterHutData(FarmManager.FARM_ID _farmId, int monsterHutPlaceId) { }

	// RVA: 0x2176920 Offset: 0x2176A21 VA: 0x2176920
	public void SetMonsterHutData(FarmManager.FARM_ID _farmId, int monsterHutPlaceId, MonsterHutSaveData monsterHutSaveData) { }

	// RVA: 0x2176AA0 Offset: 0x2176BA1 VA: 0x2176AA0
	public void SetMonsterHutMonsterData(FarmManager.FARM_ID _farmId, int monsterHutPlaceId, int monsterHutAreaId, FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2176E40 Offset: 0x2176F41 VA: 0x2176E40
	public void SetMonsterHutMonsterData(FarmManager.FARM_ID _farmId, int monsterHutPlaceId, FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2177280 Offset: 0x2177381 VA: 0x2177280
	public void SetMonsterHutMonsterData(FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2177620 Offset: 0x2177721 VA: 0x2177620
	public void ShiftMonsterHutMonsterData(FarmManager.FARM_ID id, int hutPlaceId, int areaId, FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2177BB0 Offset: 0x2177CB1 VA: 0x2177BB0
	public void ShiftMonsterHutMonsterData(FarmManager.FARM_ID id, int hutPlaceId, FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2177830 Offset: 0x2177931 VA: 0x2177830
	private void ReplaceMonsterDataToPartyMonsterDataMonsterHutRoom(FarmManager.FARM_ID id, int hutPlaceId, int areaId, FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2177DA0 Offset: 0x2177EA1 VA: 0x2177DA0
	public void RemoveMonsterHutMonsterData(FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x216ECA0 Offset: 0x216EDA1 VA: 0x216ECA0
	public int GetMonsterHutEmptyCountTotal() { }

	// RVA: 0x2177130 Offset: 0x2177231 VA: 0x2177130
	public int GetMonsterHutEmptyCount(FarmManager.FARM_ID farmId, int monsterHutPlaceId) { }

	// RVA: 0x2176CD0 Offset: 0x2176DD1 VA: 0x2176CD0
	public int GetMonsterHutAreaEmptyCount(FarmManager.FARM_ID farmId, int monsterHutPlaceId, int areaId) { }

	// RVA: 0x2176E10 Offset: 0x2176F11 VA: 0x2176E10
	public bool CheckReleaseMonsterHutArea(FarmManager.FARM_ID farmId, int monsterHutPlaceId) { }

	// RVA: 0x2178030 Offset: 0x2178131 VA: 0x2178030
	public void AddMonsterHutArea(FarmManager.FARM_ID farmId, int monsterHutPlaceId) { }

	// RVA: 0x2176DE0 Offset: 0x2176EE1 VA: 0x2176DE0
	public bool CheckReleaseMonsterHutPlace(FarmManager.FARM_ID farmId, int monsterHutPlaceId) { }

	// RVA: 0x21781A0 Offset: 0x21782A1 VA: 0x21781A0
	public void ReleaseMonsterHutPlace(FarmManager.FARM_ID farmId, int monsterHutPlaceId) { }

	// RVA: 0x2174F60 Offset: 0x2175061 VA: 0x2174F60
	public void AddYieldItem(int roomId, FriendMonsterStatus friendMonsterStatus) { }

	// RVA: 0x2178260 Offset: 0x2178361 VA: 0x2178260
	public void RemoveYieldItem(OnGroundItem onGroundItem) { }

	// RVA: 0x2178410 Offset: 0x2178511 VA: 0x2178410
	public void MorningFunc() { }

	// RVA: 0x2175220 Offset: 0x2175321 VA: 0x2175220
	public List<int> GetYieldItem(int roomId) { }

	// RVA: 0x21785B0 Offset: 0x21786B1 VA: 0x21785B0
	private void createDebugDatas() { }

	// RVA: 0x2178780 Offset: 0x2178881 VA: 0x2178780
	public void .ctor() { }
}


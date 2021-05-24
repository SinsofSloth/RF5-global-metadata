public class MonsterHutController : MonoBehaviour // TypeDefIndex: 9930
{
	// Fields
	[SerializeField] // RVA: 0x17FAE0 Offset: 0x17FBE1 VA: 0x17FAE0
	private List<GameObject> HutAreas; // 0x18
	[SerializeField] // RVA: 0x17FAF0 Offset: 0x17FBF1 VA: 0x17FAF0
	private List<MonsterHutArea> MonsterAreas; // 0x20
	[SerializeField] // RVA: 0x17FB00 Offset: 0x17FC01 VA: 0x17FB00
	private List<GameObject> Doors; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FB10 Offset: 0x17FC11 VA: 0x17FB10
	private FarmManager.FARM_ID <FarmId>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x17FB20 Offset: 0x17FC21 VA: 0x17FB20
	private int <MonsterHutPlaceId>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x17FB30 Offset: 0x17FC31 VA: 0x17FB30
	private int <AreaReleaseState>k__BackingField; // 0x38
	private MonsterHutSaveData monsterHutSaveData; // 0x40
	private Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>> FarmAIDicDic; // 0x68
	private Dictionary<uint, ActorID> FarmMonsterToActiorIDDic; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x17FB40 Offset: 0x17FC41 VA: 0x17FB40
	private int <CurrentPlayerArea>k__BackingField; // 0x78
	private List<MonsterHutController.OrderFarmInParameter> FarmInOrderList; // 0x80
	private MonsterHutController.OrderFarmInParameter CurrentOrderFarmInParam; // 0x88
	private bool IsCreating; // 0x90
	public Dictionary<OnGroundItem, int> yieldItemList; // 0x98

	// Properties
	public FarmManager.FARM_ID FarmId { get; set; }
	public int MonsterHutPlaceId { get; set; }
	public int AreaReleaseState { get; set; }
	public int CurrentPlayerArea { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD4F0 Offset: 0x1AD5F1 VA: 0x1AD4F0
	// RVA: 0x2174190 Offset: 0x2174291 VA: 0x2174190
	public void set_FarmId(FarmManager.FARM_ID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD500 Offset: 0x1AD601 VA: 0x1AD500
	// RVA: 0x21741A0 Offset: 0x21742A1 VA: 0x21741A0
	public FarmManager.FARM_ID get_FarmId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD510 Offset: 0x1AD611 VA: 0x1AD510
	// RVA: 0x21741B0 Offset: 0x21742B1 VA: 0x21741B0
	public void set_MonsterHutPlaceId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD520 Offset: 0x1AD621 VA: 0x1AD520
	// RVA: 0x21741C0 Offset: 0x21742C1 VA: 0x21741C0
	public int get_MonsterHutPlaceId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD530 Offset: 0x1AD631 VA: 0x1AD530
	// RVA: 0x21741D0 Offset: 0x21742D1 VA: 0x21741D0
	public void set_AreaReleaseState(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD540 Offset: 0x1AD641 VA: 0x1AD540
	// RVA: 0x21741E0 Offset: 0x21742E1 VA: 0x21741E0
	public int get_AreaReleaseState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD550 Offset: 0x1AD651 VA: 0x1AD550
	// RVA: 0x21741F0 Offset: 0x21742F1 VA: 0x21741F0
	public int get_CurrentPlayerArea() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD560 Offset: 0x1AD661 VA: 0x1AD560
	// RVA: 0x2174200 Offset: 0x2174301 VA: 0x2174200
	private void set_CurrentPlayerArea(int value) { }

	// RVA: 0x2174210 Offset: 0x2174311 VA: 0x2174210
	public ActorID GetActorID(uint friendMonsterDataId) { }

	// RVA: 0x21742B0 Offset: 0x21743B1 VA: 0x21742B0
	public bool IsExistMonster(FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2174310 Offset: 0x2174411 VA: 0x2174310
	private void ResetOrderList() { }

	// RVA: 0x2174380 Offset: 0x2174481 VA: 0x2174380
	public void Initialize() { }

	// RVA: 0x2174560 Offset: 0x2174661 VA: 0x2174560
	public void SetAreas() { }

	// RVA: 0x2175440 Offset: 0x2175541 VA: 0x2175440
	private void SetMonsterRoom(int roomId, uint friendMonsterDataId, ActorID actorId) { }

	// RVA: 0x2175630 Offset: 0x2175731 VA: 0x2175630
	private void FarmInCallBack(uint monsterId, ActorID actorId) { }

	// RVA: 0x2174E90 Offset: 0x2174F91 VA: 0x2174E90
	public void SetMonsters() { }

	// RVA: 0x21758B0 Offset: 0x21759B1 VA: 0x21758B0
	public void AddMonster(uint friendMonsterDataID, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175A00 Offset: 0x2175B01 VA: 0x2175A00
	public void OrderFarmIn(uint friendMonsterDataID, int roomId, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175B60 Offset: 0x2175C61 VA: 0x2175B60
	public void UpdateOrderFarmInList() { }

	// RVA: 0x2175C60 Offset: 0x2175D61 VA: 0x2175C60
	public bool RemoveMonster(uint friendMonsterDataID, bool isFarmOut = True, bool isPlayEffect = False) { }

	// RVA: 0x21757B0 Offset: 0x21758B1 VA: 0x21757B0
	public void ResetFarmAIs() { }

	// RVA: 0x2175DF0 Offset: 0x2175EF1 VA: 0x2175DF0
	private void FarmAreaAIUpdate(int areaIndex, bool isPlayerInArea) { }

	// RVA: 0x2175FA0 Offset: 0x21760A1 VA: 0x2175FA0
	public void OnPlayerEnterArea(int areaIndex) { }

	// RVA: 0x2176060 Offset: 0x2176161 VA: 0x2176060
	private void OnBeginTeleport() { }

	// RVA: 0x21761A0 Offset: 0x21762A1 VA: 0x21761A0
	private void OnDestroy() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD570 Offset: 0x1AD671 VA: 0x1AD570
	// RVA: 0x21762A0 Offset: 0x21763A1 VA: 0x21762A0
	private IEnumerator Start() { }

	// RVA: 0x2176350 Offset: 0x2176451 VA: 0x2176350
	private void Update() { }

	// RVA: 0x2176360 Offset: 0x2176461 VA: 0x2176360
	public void .ctor() { }
}

public class MonsterHutController : MonoBehaviour // TypeDefIndex: 9930
{
	// Fields
	[SerializeField] // RVA: 0x17FAE0 Offset: 0x17FBE1 VA: 0x17FAE0
	private List<GameObject> HutAreas; // 0x18
	[SerializeField] // RVA: 0x17FAF0 Offset: 0x17FBF1 VA: 0x17FAF0
	private List<MonsterHutArea> MonsterAreas; // 0x20
	[SerializeField] // RVA: 0x17FB00 Offset: 0x17FC01 VA: 0x17FB00
	private List<GameObject> Doors; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FB10 Offset: 0x17FC11 VA: 0x17FB10
	private FarmManager.FARM_ID <FarmId>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x17FB20 Offset: 0x17FC21 VA: 0x17FB20
	private int <MonsterHutPlaceId>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x17FB30 Offset: 0x17FC31 VA: 0x17FB30
	private int <AreaReleaseState>k__BackingField; // 0x38
	private MonsterHutSaveData monsterHutSaveData; // 0x40
	private Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>> FarmAIDicDic; // 0x68
	private Dictionary<uint, ActorID> FarmMonsterToActiorIDDic; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x17FB40 Offset: 0x17FC41 VA: 0x17FB40
	private int <CurrentPlayerArea>k__BackingField; // 0x78
	private List<MonsterHutController.OrderFarmInParameter> FarmInOrderList; // 0x80
	private MonsterHutController.OrderFarmInParameter CurrentOrderFarmInParam; // 0x88
	private bool IsCreating; // 0x90
	public Dictionary<OnGroundItem, int> yieldItemList; // 0x98

	// Properties
	public FarmManager.FARM_ID FarmId { get; set; }
	public int MonsterHutPlaceId { get; set; }
	public int AreaReleaseState { get; set; }
	public int CurrentPlayerArea { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD4F0 Offset: 0x1AD5F1 VA: 0x1AD4F0
	// RVA: 0x2174190 Offset: 0x2174291 VA: 0x2174190
	public void set_FarmId(FarmManager.FARM_ID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD500 Offset: 0x1AD601 VA: 0x1AD500
	// RVA: 0x21741A0 Offset: 0x21742A1 VA: 0x21741A0
	public FarmManager.FARM_ID get_FarmId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD510 Offset: 0x1AD611 VA: 0x1AD510
	// RVA: 0x21741B0 Offset: 0x21742B1 VA: 0x21741B0
	public void set_MonsterHutPlaceId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD520 Offset: 0x1AD621 VA: 0x1AD520
	// RVA: 0x21741C0 Offset: 0x21742C1 VA: 0x21741C0
	public int get_MonsterHutPlaceId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD530 Offset: 0x1AD631 VA: 0x1AD530
	// RVA: 0x21741D0 Offset: 0x21742D1 VA: 0x21741D0
	public void set_AreaReleaseState(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD540 Offset: 0x1AD641 VA: 0x1AD540
	// RVA: 0x21741E0 Offset: 0x21742E1 VA: 0x21741E0
	public int get_AreaReleaseState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD550 Offset: 0x1AD651 VA: 0x1AD550
	// RVA: 0x21741F0 Offset: 0x21742F1 VA: 0x21741F0
	public int get_CurrentPlayerArea() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD560 Offset: 0x1AD661 VA: 0x1AD560
	// RVA: 0x2174200 Offset: 0x2174301 VA: 0x2174200
	private void set_CurrentPlayerArea(int value) { }

	// RVA: 0x2174210 Offset: 0x2174311 VA: 0x2174210
	public ActorID GetActorID(uint friendMonsterDataId) { }

	// RVA: 0x21742B0 Offset: 0x21743B1 VA: 0x21742B0
	public bool IsExistMonster(FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2174310 Offset: 0x2174411 VA: 0x2174310
	private void ResetOrderList() { }

	// RVA: 0x2174380 Offset: 0x2174481 VA: 0x2174380
	public void Initialize() { }

	// RVA: 0x2174560 Offset: 0x2174661 VA: 0x2174560
	public void SetAreas() { }

	// RVA: 0x2175440 Offset: 0x2175541 VA: 0x2175440
	private void SetMonsterRoom(int roomId, uint friendMonsterDataId, ActorID actorId) { }

	// RVA: 0x2175630 Offset: 0x2175731 VA: 0x2175630
	private void FarmInCallBack(uint monsterId, ActorID actorId) { }

	// RVA: 0x2174E90 Offset: 0x2174F91 VA: 0x2174E90
	public void SetMonsters() { }

	// RVA: 0x21758B0 Offset: 0x21759B1 VA: 0x21758B0
	public void AddMonster(uint friendMonsterDataID, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175A00 Offset: 0x2175B01 VA: 0x2175A00
	public void OrderFarmIn(uint friendMonsterDataID, int roomId, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175B60 Offset: 0x2175C61 VA: 0x2175B60
	public void UpdateOrderFarmInList() { }

	// RVA: 0x2175C60 Offset: 0x2175D61 VA: 0x2175C60
	public bool RemoveMonster(uint friendMonsterDataID, bool isFarmOut = True, bool isPlayEffect = False) { }

	// RVA: 0x21757B0 Offset: 0x21758B1 VA: 0x21757B0
	public void ResetFarmAIs() { }

	// RVA: 0x2175DF0 Offset: 0x2175EF1 VA: 0x2175DF0
	private void FarmAreaAIUpdate(int areaIndex, bool isPlayerInArea) { }

	// RVA: 0x2175FA0 Offset: 0x21760A1 VA: 0x2175FA0
	public void OnPlayerEnterArea(int areaIndex) { }

	// RVA: 0x2176060 Offset: 0x2176161 VA: 0x2176060
	private void OnBeginTeleport() { }

	// RVA: 0x21761A0 Offset: 0x21762A1 VA: 0x21761A0
	private void OnDestroy() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD570 Offset: 0x1AD671 VA: 0x1AD570
	// RVA: 0x21762A0 Offset: 0x21763A1 VA: 0x21762A0
	private IEnumerator Start() { }

	// RVA: 0x2176350 Offset: 0x2176451 VA: 0x2176350
	private void Update() { }

	// RVA: 0x2176360 Offset: 0x2176461 VA: 0x2176360
	public void .ctor() { }
}

public class MonsterHutController : MonoBehaviour // TypeDefIndex: 9930
{
	// Fields
	[SerializeField] // RVA: 0x17FAE0 Offset: 0x17FBE1 VA: 0x17FAE0
	private List<GameObject> HutAreas; // 0x18
	[SerializeField] // RVA: 0x17FAF0 Offset: 0x17FBF1 VA: 0x17FAF0
	private List<MonsterHutArea> MonsterAreas; // 0x20
	[SerializeField] // RVA: 0x17FB00 Offset: 0x17FC01 VA: 0x17FB00
	private List<GameObject> Doors; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FB10 Offset: 0x17FC11 VA: 0x17FB10
	private FarmManager.FARM_ID <FarmId>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x17FB20 Offset: 0x17FC21 VA: 0x17FB20
	private int <MonsterHutPlaceId>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x17FB30 Offset: 0x17FC31 VA: 0x17FB30
	private int <AreaReleaseState>k__BackingField; // 0x38
	private MonsterHutSaveData monsterHutSaveData; // 0x40
	private Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>> FarmAIDicDic; // 0x68
	private Dictionary<uint, ActorID> FarmMonsterToActiorIDDic; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x17FB40 Offset: 0x17FC41 VA: 0x17FB40
	private int <CurrentPlayerArea>k__BackingField; // 0x78
	private List<MonsterHutController.OrderFarmInParameter> FarmInOrderList; // 0x80
	private MonsterHutController.OrderFarmInParameter CurrentOrderFarmInParam; // 0x88
	private bool IsCreating; // 0x90
	public Dictionary<OnGroundItem, int> yieldItemList; // 0x98

	// Properties
	public FarmManager.FARM_ID FarmId { get; set; }
	public int MonsterHutPlaceId { get; set; }
	public int AreaReleaseState { get; set; }
	public int CurrentPlayerArea { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD4F0 Offset: 0x1AD5F1 VA: 0x1AD4F0
	// RVA: 0x2174190 Offset: 0x2174291 VA: 0x2174190
	public void set_FarmId(FarmManager.FARM_ID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD500 Offset: 0x1AD601 VA: 0x1AD500
	// RVA: 0x21741A0 Offset: 0x21742A1 VA: 0x21741A0
	public FarmManager.FARM_ID get_FarmId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD510 Offset: 0x1AD611 VA: 0x1AD510
	// RVA: 0x21741B0 Offset: 0x21742B1 VA: 0x21741B0
	public void set_MonsterHutPlaceId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD520 Offset: 0x1AD621 VA: 0x1AD520
	// RVA: 0x21741C0 Offset: 0x21742C1 VA: 0x21741C0
	public int get_MonsterHutPlaceId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD530 Offset: 0x1AD631 VA: 0x1AD530
	// RVA: 0x21741D0 Offset: 0x21742D1 VA: 0x21741D0
	public void set_AreaReleaseState(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD540 Offset: 0x1AD641 VA: 0x1AD540
	// RVA: 0x21741E0 Offset: 0x21742E1 VA: 0x21741E0
	public int get_AreaReleaseState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD550 Offset: 0x1AD651 VA: 0x1AD550
	// RVA: 0x21741F0 Offset: 0x21742F1 VA: 0x21741F0
	public int get_CurrentPlayerArea() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD560 Offset: 0x1AD661 VA: 0x1AD560
	// RVA: 0x2174200 Offset: 0x2174301 VA: 0x2174200
	private void set_CurrentPlayerArea(int value) { }

	// RVA: 0x2174210 Offset: 0x2174311 VA: 0x2174210
	public ActorID GetActorID(uint friendMonsterDataId) { }

	// RVA: 0x21742B0 Offset: 0x21743B1 VA: 0x21742B0
	public bool IsExistMonster(FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2174310 Offset: 0x2174411 VA: 0x2174310
	private void ResetOrderList() { }

	// RVA: 0x2174380 Offset: 0x2174481 VA: 0x2174380
	public void Initialize() { }

	// RVA: 0x2174560 Offset: 0x2174661 VA: 0x2174560
	public void SetAreas() { }

	// RVA: 0x2175440 Offset: 0x2175541 VA: 0x2175440
	private void SetMonsterRoom(int roomId, uint friendMonsterDataId, ActorID actorId) { }

	// RVA: 0x2175630 Offset: 0x2175731 VA: 0x2175630
	private void FarmInCallBack(uint monsterId, ActorID actorId) { }

	// RVA: 0x2174E90 Offset: 0x2174F91 VA: 0x2174E90
	public void SetMonsters() { }

	// RVA: 0x21758B0 Offset: 0x21759B1 VA: 0x21758B0
	public void AddMonster(uint friendMonsterDataID, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175A00 Offset: 0x2175B01 VA: 0x2175A00
	public void OrderFarmIn(uint friendMonsterDataID, int roomId, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175B60 Offset: 0x2175C61 VA: 0x2175B60
	public void UpdateOrderFarmInList() { }

	// RVA: 0x2175C60 Offset: 0x2175D61 VA: 0x2175C60
	public bool RemoveMonster(uint friendMonsterDataID, bool isFarmOut = True, bool isPlayEffect = False) { }

	// RVA: 0x21757B0 Offset: 0x21758B1 VA: 0x21757B0
	public void ResetFarmAIs() { }

	// RVA: 0x2175DF0 Offset: 0x2175EF1 VA: 0x2175DF0
	private void FarmAreaAIUpdate(int areaIndex, bool isPlayerInArea) { }

	// RVA: 0x2175FA0 Offset: 0x21760A1 VA: 0x2175FA0
	public void OnPlayerEnterArea(int areaIndex) { }

	// RVA: 0x2176060 Offset: 0x2176161 VA: 0x2176060
	private void OnBeginTeleport() { }

	// RVA: 0x21761A0 Offset: 0x21762A1 VA: 0x21761A0
	private void OnDestroy() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD570 Offset: 0x1AD671 VA: 0x1AD570
	// RVA: 0x21762A0 Offset: 0x21763A1 VA: 0x21762A0
	private IEnumerator Start() { }

	// RVA: 0x2176350 Offset: 0x2176451 VA: 0x2176350
	private void Update() { }

	// RVA: 0x2176360 Offset: 0x2176461 VA: 0x2176360
	public void .ctor() { }
}

public class MonsterHutController : MonoBehaviour // TypeDefIndex: 9930
{
	// Fields
	[SerializeField] // RVA: 0x17FAE0 Offset: 0x17FBE1 VA: 0x17FAE0
	private List<GameObject> HutAreas; // 0x18
	[SerializeField] // RVA: 0x17FAF0 Offset: 0x17FBF1 VA: 0x17FAF0
	private List<MonsterHutArea> MonsterAreas; // 0x20
	[SerializeField] // RVA: 0x17FB00 Offset: 0x17FC01 VA: 0x17FB00
	private List<GameObject> Doors; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FB10 Offset: 0x17FC11 VA: 0x17FB10
	private FarmManager.FARM_ID <FarmId>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x17FB20 Offset: 0x17FC21 VA: 0x17FB20
	private int <MonsterHutPlaceId>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x17FB30 Offset: 0x17FC31 VA: 0x17FB30
	private int <AreaReleaseState>k__BackingField; // 0x38
	private MonsterHutSaveData monsterHutSaveData; // 0x40
	private Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>> FarmAIDicDic; // 0x68
	private Dictionary<uint, ActorID> FarmMonsterToActiorIDDic; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x17FB40 Offset: 0x17FC41 VA: 0x17FB40
	private int <CurrentPlayerArea>k__BackingField; // 0x78
	private List<MonsterHutController.OrderFarmInParameter> FarmInOrderList; // 0x80
	private MonsterHutController.OrderFarmInParameter CurrentOrderFarmInParam; // 0x88
	private bool IsCreating; // 0x90
	public Dictionary<OnGroundItem, int> yieldItemList; // 0x98

	// Properties
	public FarmManager.FARM_ID FarmId { get; set; }
	public int MonsterHutPlaceId { get; set; }
	public int AreaReleaseState { get; set; }
	public int CurrentPlayerArea { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD4F0 Offset: 0x1AD5F1 VA: 0x1AD4F0
	// RVA: 0x2174190 Offset: 0x2174291 VA: 0x2174190
	public void set_FarmId(FarmManager.FARM_ID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD500 Offset: 0x1AD601 VA: 0x1AD500
	// RVA: 0x21741A0 Offset: 0x21742A1 VA: 0x21741A0
	public FarmManager.FARM_ID get_FarmId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD510 Offset: 0x1AD611 VA: 0x1AD510
	// RVA: 0x21741B0 Offset: 0x21742B1 VA: 0x21741B0
	public void set_MonsterHutPlaceId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD520 Offset: 0x1AD621 VA: 0x1AD520
	// RVA: 0x21741C0 Offset: 0x21742C1 VA: 0x21741C0
	public int get_MonsterHutPlaceId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD530 Offset: 0x1AD631 VA: 0x1AD530
	// RVA: 0x21741D0 Offset: 0x21742D1 VA: 0x21741D0
	public void set_AreaReleaseState(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD540 Offset: 0x1AD641 VA: 0x1AD540
	// RVA: 0x21741E0 Offset: 0x21742E1 VA: 0x21741E0
	public int get_AreaReleaseState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD550 Offset: 0x1AD651 VA: 0x1AD550
	// RVA: 0x21741F0 Offset: 0x21742F1 VA: 0x21741F0
	public int get_CurrentPlayerArea() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD560 Offset: 0x1AD661 VA: 0x1AD560
	// RVA: 0x2174200 Offset: 0x2174301 VA: 0x2174200
	private void set_CurrentPlayerArea(int value) { }

	// RVA: 0x2174210 Offset: 0x2174311 VA: 0x2174210
	public ActorID GetActorID(uint friendMonsterDataId) { }

	// RVA: 0x21742B0 Offset: 0x21743B1 VA: 0x21742B0
	public bool IsExistMonster(FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2174310 Offset: 0x2174411 VA: 0x2174310
	private void ResetOrderList() { }

	// RVA: 0x2174380 Offset: 0x2174481 VA: 0x2174380
	public void Initialize() { }

	// RVA: 0x2174560 Offset: 0x2174661 VA: 0x2174560
	public void SetAreas() { }

	// RVA: 0x2175440 Offset: 0x2175541 VA: 0x2175440
	private void SetMonsterRoom(int roomId, uint friendMonsterDataId, ActorID actorId) { }

	// RVA: 0x2175630 Offset: 0x2175731 VA: 0x2175630
	private void FarmInCallBack(uint monsterId, ActorID actorId) { }

	// RVA: 0x2174E90 Offset: 0x2174F91 VA: 0x2174E90
	public void SetMonsters() { }

	// RVA: 0x21758B0 Offset: 0x21759B1 VA: 0x21758B0
	public void AddMonster(uint friendMonsterDataID, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175A00 Offset: 0x2175B01 VA: 0x2175A00
	public void OrderFarmIn(uint friendMonsterDataID, int roomId, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175B60 Offset: 0x2175C61 VA: 0x2175B60
	public void UpdateOrderFarmInList() { }

	// RVA: 0x2175C60 Offset: 0x2175D61 VA: 0x2175C60
	public bool RemoveMonster(uint friendMonsterDataID, bool isFarmOut = True, bool isPlayEffect = False) { }

	// RVA: 0x21757B0 Offset: 0x21758B1 VA: 0x21757B0
	public void ResetFarmAIs() { }

	// RVA: 0x2175DF0 Offset: 0x2175EF1 VA: 0x2175DF0
	private void FarmAreaAIUpdate(int areaIndex, bool isPlayerInArea) { }

	// RVA: 0x2175FA0 Offset: 0x21760A1 VA: 0x2175FA0
	public void OnPlayerEnterArea(int areaIndex) { }

	// RVA: 0x2176060 Offset: 0x2176161 VA: 0x2176060
	private void OnBeginTeleport() { }

	// RVA: 0x21761A0 Offset: 0x21762A1 VA: 0x21761A0
	private void OnDestroy() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD570 Offset: 0x1AD671 VA: 0x1AD570
	// RVA: 0x21762A0 Offset: 0x21763A1 VA: 0x21762A0
	private IEnumerator Start() { }

	// RVA: 0x2176350 Offset: 0x2176451 VA: 0x2176350
	private void Update() { }

	// RVA: 0x2176360 Offset: 0x2176461 VA: 0x2176360
	public void .ctor() { }
}

public class MonsterHutController : MonoBehaviour // TypeDefIndex: 9930
{
	// Fields
	[SerializeField] // RVA: 0x17FAE0 Offset: 0x17FBE1 VA: 0x17FAE0
	private List<GameObject> HutAreas; // 0x18
	[SerializeField] // RVA: 0x17FAF0 Offset: 0x17FBF1 VA: 0x17FAF0
	private List<MonsterHutArea> MonsterAreas; // 0x20
	[SerializeField] // RVA: 0x17FB00 Offset: 0x17FC01 VA: 0x17FB00
	private List<GameObject> Doors; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x17FB10 Offset: 0x17FC11 VA: 0x17FB10
	private FarmManager.FARM_ID <FarmId>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x17FB20 Offset: 0x17FC21 VA: 0x17FB20
	private int <MonsterHutPlaceId>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x17FB30 Offset: 0x17FC31 VA: 0x17FB30
	private int <AreaReleaseState>k__BackingField; // 0x38
	private MonsterHutSaveData monsterHutSaveData; // 0x40
	private Dictionary<int, Dictionary<uint, FarmMonsterBehaviorController>> FarmAIDicDic; // 0x68
	private Dictionary<uint, ActorID> FarmMonsterToActiorIDDic; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x17FB40 Offset: 0x17FC41 VA: 0x17FB40
	private int <CurrentPlayerArea>k__BackingField; // 0x78
	private List<MonsterHutController.OrderFarmInParameter> FarmInOrderList; // 0x80
	private MonsterHutController.OrderFarmInParameter CurrentOrderFarmInParam; // 0x88
	private bool IsCreating; // 0x90
	public Dictionary<OnGroundItem, int> yieldItemList; // 0x98

	// Properties
	public FarmManager.FARM_ID FarmId { get; set; }
	public int MonsterHutPlaceId { get; set; }
	public int AreaReleaseState { get; set; }
	public int CurrentPlayerArea { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AD4F0 Offset: 0x1AD5F1 VA: 0x1AD4F0
	// RVA: 0x2174190 Offset: 0x2174291 VA: 0x2174190
	public void set_FarmId(FarmManager.FARM_ID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD500 Offset: 0x1AD601 VA: 0x1AD500
	// RVA: 0x21741A0 Offset: 0x21742A1 VA: 0x21741A0
	public FarmManager.FARM_ID get_FarmId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD510 Offset: 0x1AD611 VA: 0x1AD510
	// RVA: 0x21741B0 Offset: 0x21742B1 VA: 0x21741B0
	public void set_MonsterHutPlaceId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD520 Offset: 0x1AD621 VA: 0x1AD520
	// RVA: 0x21741C0 Offset: 0x21742C1 VA: 0x21741C0
	public int get_MonsterHutPlaceId() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD530 Offset: 0x1AD631 VA: 0x1AD530
	// RVA: 0x21741D0 Offset: 0x21742D1 VA: 0x21741D0
	public void set_AreaReleaseState(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD540 Offset: 0x1AD641 VA: 0x1AD540
	// RVA: 0x21741E0 Offset: 0x21742E1 VA: 0x21741E0
	public int get_AreaReleaseState() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD550 Offset: 0x1AD651 VA: 0x1AD550
	// RVA: 0x21741F0 Offset: 0x21742F1 VA: 0x21741F0
	public int get_CurrentPlayerArea() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AD560 Offset: 0x1AD661 VA: 0x1AD560
	// RVA: 0x2174200 Offset: 0x2174301 VA: 0x2174200
	private void set_CurrentPlayerArea(int value) { }

	// RVA: 0x2174210 Offset: 0x2174311 VA: 0x2174210
	public ActorID GetActorID(uint friendMonsterDataId) { }

	// RVA: 0x21742B0 Offset: 0x21743B1 VA: 0x21742B0
	public bool IsExistMonster(FriendMonsterStatusData friendMonsterStatusData) { }

	// RVA: 0x2174310 Offset: 0x2174411 VA: 0x2174310
	private void ResetOrderList() { }

	// RVA: 0x2174380 Offset: 0x2174481 VA: 0x2174380
	public void Initialize() { }

	// RVA: 0x2174560 Offset: 0x2174661 VA: 0x2174560
	public void SetAreas() { }

	// RVA: 0x2175440 Offset: 0x2175541 VA: 0x2175440
	private void SetMonsterRoom(int roomId, uint friendMonsterDataId, ActorID actorId) { }

	// RVA: 0x2175630 Offset: 0x2175731 VA: 0x2175630
	private void FarmInCallBack(uint monsterId, ActorID actorId) { }

	// RVA: 0x2174E90 Offset: 0x2174F91 VA: 0x2174E90
	public void SetMonsters() { }

	// RVA: 0x21758B0 Offset: 0x21759B1 VA: 0x21758B0
	public void AddMonster(uint friendMonsterDataID, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175A00 Offset: 0x2175B01 VA: 0x2175A00
	public void OrderFarmIn(uint friendMonsterDataID, int roomId, Action<uint, ActorID> callBack) { }

	// RVA: 0x2175B60 Offset: 0x2175C61 VA: 0x2175B60
	public void UpdateOrderFarmInList() { }

	// RVA: 0x2175C60 Offset: 0x2175D61 VA: 0x2175C60
	public bool RemoveMonster(uint friendMonsterDataID, bool isFarmOut = True, bool isPlayEffect = False) { }

	// RVA: 0x21757B0 Offset: 0x21758B1 VA: 0x21757B0
	public void ResetFarmAIs() { }

	// RVA: 0x2175DF0 Offset: 0x2175EF1 VA: 0x2175DF0
	private void FarmAreaAIUpdate(int areaIndex, bool isPlayerInArea) { }

	// RVA: 0x2175FA0 Offset: 0x21760A1 VA: 0x2175FA0
	public void OnPlayerEnterArea(int areaIndex) { }

	// RVA: 0x2176060 Offset: 0x2176161 VA: 0x2176060
	private void OnBeginTeleport() { }

	// RVA: 0x21761A0 Offset: 0x21762A1 VA: 0x21761A0
	private void OnDestroy() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AD570 Offset: 0x1AD671 VA: 0x1AD570
	// RVA: 0x21762A0 Offset: 0x21763A1 VA: 0x21762A0
	private IEnumerator Start() { }

	// RVA: 0x2176350 Offset: 0x2176451 VA: 0x2176350
	private void Update() { }

	// RVA: 0x2176360 Offset: 0x2176461 VA: 0x2176360
	public void .ctor() { }
}


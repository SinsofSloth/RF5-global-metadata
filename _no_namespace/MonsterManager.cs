public class MonsterManager : SingletonMonoBehaviour<MonsterManager> // TypeDefIndex: 8007
{
	// Fields
	private static readonly Vector3 LoadSpwanPoint; // 0x0
	private const string AssetPath = "Assets/AssetBundleDatas/";
	private const string DogBehaviorName = "BossBehavior";
	private UnknownTask task; // 0x18
	private const int EnemyPriorityMax = 99;
	private const int EnemyPriorityMin = 10;
	private Dictionary<GateDataID, GateController> GateControllerDic; // 0x20
	private Dictionary<int, BossStageManager> BossStageManagerDic; // 0x28
	public List<MonsterControllerBase> CreatedEnemyControllerList; // 0x30
	public List<MonsterControllerBase> CreatedFriendControllerList; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x169F40 Offset: 0x16A041 VA: 0x169F40
	private bool <IsUpdateResourceList>k__BackingField; // 0x40
	public UnityEvent OnEndUpdateResourceList; // 0x48
	private WantedMonsterManager WantedMonsterManager; // 0x50
	private int NavmeshPriority; // 0x58
	private MonsterModelDataTable MonsterModelDataTable; // 0x60
	private Dictionary<Master, MonsterActionCodeDataTableArray> LoadActionCodeDataDic; // 0x68

	// Properties
	public bool IsUpdateResourceList { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A50E0 Offset: 0x1A51E1 VA: 0x1A50E0
	// RVA: 0x1CCB440 Offset: 0x1CCB541 VA: 0x1CCB440
	public bool get_IsUpdateResourceList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A50F0 Offset: 0x1A51F1 VA: 0x1A50F0
	// RVA: 0x1CCB450 Offset: 0x1CCB551 VA: 0x1CCB450
	private void set_IsUpdateResourceList(bool value) { }

	// RVA: 0x1CCB460 Offset: 0x1CCB561 VA: 0x1CCB460
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1CCC040 Offset: 0x1CCC141 VA: 0x1CCC040 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1CCC1B0 Offset: 0x1CCC2B1 VA: 0x1CCC1B0
	private void OnDestroy() { }

	// RVA: 0x1CCC3B0 Offset: 0x1CCC4B1 VA: 0x1CCC3B0
	private void Update() { }

	// RVA: 0x1CCC500 Offset: 0x1CCC601 VA: 0x1CCC500
	private void OnCarryDay(int carryDay) { }

	// RVA: 0x1CCC530 Offset: 0x1CCC631 VA: 0x1CCC530
	private void OnBeginTeleport() { }

	// RVA: 0x1CCC540 Offset: 0x1CCC641 VA: 0x1CCC540
	private void OnEndTeleport() { }

	// RVA: 0x1CCC590 Offset: 0x1CCC691 VA: 0x1CCC590
	public GateController GetGateController(GateDataID gateDataID) { }

	// RVA: 0x1CCBAF0 Offset: 0x1CCBBF1 VA: 0x1CCBAF0
	private void FindGateAndBossStage() { }

	// RVA: 0x1CCBCF0 Offset: 0x1CCBDF1 VA: 0x1CCBCF0
	private void GateInit() { }

	// RVA: 0x1CCBE50 Offset: 0x1CCBF51 VA: 0x1CCBE50
	private void BossStageInit() { }

	// RVA: 0x1CCC630 Offset: 0x1CCC731 VA: 0x1CCC630
	private void InitializeGateController(GateController gateController) { }

	// RVA: 0x1CCC3E0 Offset: 0x1CCC4E1 VA: 0x1CCC3E0
	public void UpdateGateControllers() { }

	// RVA: 0x1CCC900 Offset: 0x1CCCA01 VA: 0x1CCC900
	public GateStatusDataTable GetLotteryGateStatusDataTable(GateDataTable gateDataTable) { }

	// RVA: 0x1CCCD90 Offset: 0x1CCCE91 VA: 0x1CCCD90
	public GateStatusDataTable GetSelcetGateStattusDataTable(GateDataTable gateDataTable, int eventIndex) { }

	// RVA: 0x1CCC990 Offset: 0x1CCCA91 VA: 0x1CCC990
	public GateStatusDataID GetLottryGateStatusDataID(GateDataTable gateDataTable) { }

	// RVA: 0x1CCCE70 Offset: 0x1CCCF71 VA: 0x1CCCE70
	public MonsterDataID GetLotterySpawnMonsterDataID(GateStatusDataTable gateStatusDataTable, int spawnPoint = -1) { }

	// RVA: 0x1CCB5B0 Offset: 0x1CCB6B1 VA: 0x1CCB5B0
	public void SetEnableGateControllers(bool isEnable, bool isCallback = False) { }

	// RVA: 0x1CCC780 Offset: 0x1CCC881 VA: 0x1CCC780
	public void UpdateGateState() { }

	// RVA: 0x1CCD2F0 Offset: 0x1CCD3F1 VA: 0x1CCD2F0
	public BossStageManager GetBossStageManager(int stageIndex) { }

	// RVA: 0x1CCC860 Offset: 0x1CCC961 VA: 0x1CCC860
	private void InitializeBossStageManager(BossStageManager bossStage) { }

	// RVA: 0x1CCD390 Offset: 0x1CCD491 VA: 0x1CCD390
	public void BossStagePlay(int stageIndex = 0, int eventIndex = 0, Action<BossBehaviorController> callBack) { }

	// RVA: 0x1CCD450 Offset: 0x1CCD551 VA: 0x1CCD450
	public void BossStageDestroyInstanceBoss(int stageIndex = 0) { }

	// RVA: 0x1CCD500 Offset: 0x1CCD601 VA: 0x1CCD500
	public string GetBossStageEmergenceBossName(int stageIndex, int eventIndex) { }

	// RVA: 0x1CCD5C0 Offset: 0x1CCD6C1 VA: 0x1CCD5C0
	public bool CheckBattleBossNow() { }

	// RVA: 0x1CCD6E0 Offset: 0x1CCD7E1 VA: 0x1CCD6E0
	private void AddEnemyMonster(MonsterControllerBase controller) { }

	// RVA: 0x1CCD870 Offset: 0x1CCD971 VA: 0x1CCD870
	public void SetMonsterNavMeshAgentPriority(MonsterControllerBase controller) { }

	// RVA: 0x1CCD970 Offset: 0x1CCDA71 VA: 0x1CCD970
	public void RemoveEnemyMonster(MonsterControllerBase controller) { }

	// RVA: 0x1CCD9E0 Offset: 0x1CCDAE1 VA: 0x1CCD9E0
	public void DestroyEnemyMonster(MonsterControllerBase controller) { }

	// RVA: 0x1CCB7C0 Offset: 0x1CCB8C1 VA: 0x1CCB7C0
	public void DestroyAllEnemyMonster() { }

	// RVA: 0x1CCDCA0 Offset: 0x1CCDDA1 VA: 0x1CCDCA0
	public void SetDisplayEnemy(bool isDisplay) { }

	// RVA: 0x1CCDDD0 Offset: 0x1CCDED1 VA: 0x1CCDDD0
	public void AddFriendMonster(MonsterControllerBase controller) { }

	// RVA: 0x1CCDF60 Offset: 0x1CCE061 VA: 0x1CCDF60
	private void RemoveFriendMonster(MonsterControllerBase controller) { }

	// RVA: 0x1CCDFD0 Offset: 0x1CCE0D1 VA: 0x1CCDFD0
	public void DestroyFriendMonster(MonsterControllerBase controller) { }

	// RVA: 0x1CCB980 Offset: 0x1CCBA81 VA: 0x1CCB980
	public void DestroyAllFriendMonster() { }

	// RVA: 0x1CCE200 Offset: 0x1CCE301 VA: 0x1CCE200
	public MonsterStatusBase CreateMonsterStatus(MonsterType type, int level, MonsterDataID id) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5100 Offset: 0x1A5201 VA: 0x1A5100
	// RVA: 0x1CCE300 Offset: 0x1CCE401 VA: 0x1CCE300
	public IEnumerator GetAsyncControllerModel(MonsterDataID id, MonsterType monsterType, int level, Action<MonsterControllerBase> callBack) { }

	// RVA: 0x1CCE3F0 Offset: 0x1CCE4F1 VA: 0x1CCE3F0
	public void GetControllerModel(MonsterDataID id, MonsterType monsterType, int level, Action<MonsterControllerBase> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5170 Offset: 0x1A5271 VA: 0x1A5170
	// RVA: 0x1CCE4B0 Offset: 0x1CCE5B1 VA: 0x1CCE4B0
	private IEnumerator GetAsyncControllerModel(MonsterDataID id, bool isEnemy, Action<GameObject, MonsterControllerBase> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A51E0 Offset: 0x1A52E1 VA: 0x1A51E0
	// RVA: 0x1CCE5A0 Offset: 0x1CCE6A1 VA: 0x1CCE5A0
	public IEnumerator GetAsyncControllerModel(MonsterStatusBase status, MonsterType monsterType, Action<MonsterControllerBase> callBack) { }

	// RVA: 0x1CCE690 Offset: 0x1CCE791 VA: 0x1CCE690
	public void GetControllerModel(MonsterStatusBase status, MonsterType monsterType, Action<MonsterControllerBase> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5250 Offset: 0x1A5351 VA: 0x1A5250
	// RVA: 0x1CCE6C0 Offset: 0x1CCE7C1 VA: 0x1CCE6C0
	private IEnumerator GetAsyncSpcControllerModel(MonsterDataID id, bool isEnemy, Action<GameObject, SpcMonsterController> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A52C0 Offset: 0x1A53C1 VA: 0x1A52C0
	// RVA: 0x1CCE7B0 Offset: 0x1CCE8B1 VA: 0x1CCE7B0
	private IEnumerator GetAsyncSpcControllerModel(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callBack) { }

	// RVA: 0x1CCE8A0 Offset: 0x1CCE9A1 VA: 0x1CCE8A0
	public void GetSpcControllerModel(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callBack) { }

	// RVA: 0x1CCC0F0 Offset: 0x1CCC1F1 VA: 0x1CCC0F0
	private void SetupMonsterModel() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5330 Offset: 0x1A5431 VA: 0x1A5330
	// RVA: 0x1CCEB10 Offset: 0x1CCEC11 VA: 0x1CCEB10
	private IEnumerator LoadModel(Prefab id, Action<GameObject> callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A53A0 Offset: 0x1A54A1 VA: 0x1A53A0
	// RVA: 0x1CCEBE0 Offset: 0x1CCECE1 VA: 0x1CCEBE0
	public IEnumerator GetAsyncModel(MonsterModelDataID id, bool isEnemy, bool isChangeUIScale = False, int layer = -1, Action<GameObject> callback) { }

	// RVA: 0x1CCECE0 Offset: 0x1CCEDE1 VA: 0x1CCECE0
	public void GetModel(MonsterModelDataID id, bool isEnemy, bool isChangeScale = False, int layer = -1, Action<MonsterModelDataID, GameObject> callback) { }

	// RVA: 0x1CCEE60 Offset: 0x1CCEF61 VA: 0x1CCEE60
	public void GetModel(MonsterDataID id, bool isEnemy, bool isChangeScale = False, int layer = -1, Action<MonsterDataID, GameObject> callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5410 Offset: 0x1A5511 VA: 0x1A5410
	// RVA: 0x1CCF000 Offset: 0x1CCF101 VA: 0x1CCF000
	private IEnumerator LoadAsyncController(Prefab id, Action<MonsterControllerBase> callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5480 Offset: 0x1A5581 VA: 0x1A5480
	// RVA: 0x1CCF0D0 Offset: 0x1CCF1D1 VA: 0x1CCF0D0
	private IEnumerator LoaderAsyncActionCodeData(Master actionCodeDataID, Action<MonsterActionCodeDataTableArray> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A54F0 Offset: 0x1A55F1 VA: 0x1A54F0
	// RVA: 0x1CCF1A0 Offset: 0x1CCF2A1 VA: 0x1CCF1A0
	private IEnumerator LoadAsyncSpcController(Action<SpcMonsterController> callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A5560 Offset: 0x1A5661 VA: 0x1A5560
	// RVA: 0x1CCF270 Offset: 0x1CCF371 VA: 0x1CCF270
	private IEnumerator GetAsyncController(MonsterDataID id, bool isEnemy, Action<MonsterControllerBase> callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A55D0 Offset: 0x1A56D1 VA: 0x1A55D0
	// RVA: 0x1CCF360 Offset: 0x1CCF461 VA: 0x1CCF360
	private IEnumerator GetAsyncSpcController(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callback) { }

	// RVA: 0x1CCF450 Offset: 0x1CCF551 VA: 0x1CCF450
	public void GetSpcController(MonsterDataID id, bool isEnemy, Action<SpcMonsterController> callback) { }

	// RVA: 0x1CCF510 Offset: 0x1CCF611 VA: 0x1CCF510
	public void .ctor() { }

	// RVA: 0x1CCF6A0 Offset: 0x1CCF7A1 VA: 0x1CCF6A0
	private static void .cctor() { }
}


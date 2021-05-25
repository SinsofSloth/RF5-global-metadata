public class BehaviorTreeManager : SingletonMonoBehaviour<BehaviorTreeManager> // TypeDefIndex: 6379
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15C3F0 Offset: 0x15C4F1 VA: 0x15C3F0
	private EnemyPatrolData <EnemyPatrolData>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15C400 Offset: 0x15C501 VA: 0x15C400
	private MonsterActionBehaviorDataTable <MonsterActionBehaviorDataTable>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15C410 Offset: 0x15C511 VA: 0x15C410
	private NPCActionBehaviorDataTable <NPCActionBehaviorDataTable>k__BackingField; // 0x28
	private Dictionary<Master, BossDataAssetBase> BossDataAssetBaseDic; // 0x30
	private const int MaxEnemyBehaviorPoolCount = 20;
	private ExternalBehavior EnemyExternalBehavior; // 0x38
	public List<BehaviorTreeManager.EnemyBehaviorParameter> EnemyBehaviorParameterPoolList; // 0x40
	public List<BehaviorTreeManager.EnemyBehaviorParameter> DestroyEnemyBehaviorParameterList; // 0x48
	private ExternalBehavior BossExternalBehavior; // 0x50
	public Dictionary<int, BossBehaviorController> BossBehaviorControllerDic; // 0x58
	private ExternalBehavior PartnerNPCExternalBehavior; // 0x60
	private Dictionary<int, PartnerNPCBehaviorController> PartnerNPCBehaviorControllerDic; // 0x68
	private ExternalBehavior PartnerMonsterExternalBehavior; // 0x70
	private Dictionary<int, MonsterBehaviorController> PartnerMonsterBehaviorControllerDic; // 0x78
	private ExternalBehavior FarmMonsterExternalBehavior; // 0x80

	// Properties
	public EnemyPatrolData EnemyPatrolData { get; set; }
	public MonsterActionBehaviorDataTable MonsterActionBehaviorDataTable { get; set; }
	public NPCActionBehaviorDataTable NPCActionBehaviorDataTable { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19ACD0 Offset: 0x19ADD1 VA: 0x19ACD0
	// RVA: 0x22DB1A0 Offset: 0x22DB2A1 VA: 0x22DB1A0
	public EnemyPatrolData get_EnemyPatrolData() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ACE0 Offset: 0x19ADE1 VA: 0x19ACE0
	// RVA: 0x22DB1B0 Offset: 0x22DB2B1 VA: 0x22DB1B0
	private void set_EnemyPatrolData(EnemyPatrolData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19ACF0 Offset: 0x19ADF1 VA: 0x19ACF0
	// RVA: 0x22DB1C0 Offset: 0x22DB2C1 VA: 0x22DB1C0
	public MonsterActionBehaviorDataTable get_MonsterActionBehaviorDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AD00 Offset: 0x19AE01 VA: 0x19AD00
	// RVA: 0x22DB1D0 Offset: 0x22DB2D1 VA: 0x22DB1D0
	private void set_MonsterActionBehaviorDataTable(MonsterActionBehaviorDataTable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AD10 Offset: 0x19AE11 VA: 0x19AD10
	// RVA: 0x22DB1E0 Offset: 0x22DB2E1 VA: 0x22DB1E0
	public NPCActionBehaviorDataTable get_NPCActionBehaviorDataTable() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AD20 Offset: 0x19AE21 VA: 0x19AD20
	// RVA: 0x22DB1F0 Offset: 0x22DB2F1 VA: 0x22DB1F0
	private void set_NPCActionBehaviorDataTable(NPCActionBehaviorDataTable value) { }

	// RVA: 0x22DB200 Offset: 0x22DB301 VA: 0x22DB200
	private void SetupEnemyPatrollData() { }

	// RVA: 0x22DB2C0 Offset: 0x22DB3C1 VA: 0x22DB2C0
	public void SetupMonsterActionBehaviorDataTable() { }

	// RVA: 0x22DB390 Offset: 0x22DB491 VA: 0x22DB390
	public void SetupNPCActionBehaviorDataTable() { }

	// RVA: 0x22DB460 Offset: 0x22DB561 VA: 0x22DB460
	private void LoadBossDataAsset(Master id, Action<BossDataAssetBase> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x19AD30 Offset: 0x19AE31 VA: 0x19AD30
	// RVA: 0x22DB5D0 Offset: 0x22DB6D1 VA: 0x22DB5D0
	private IEnumerator CreateAsyncEnemyBehaviorParameter(Action<BehaviorTreeManager.EnemyBehaviorParameter> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x19ADA0 Offset: 0x19AEA1 VA: 0x19ADA0
	// RVA: 0x22DB6A0 Offset: 0x22DB7A1 VA: 0x22DB6A0
	private IEnumerator GetAsyncEnemyBehavior(GameObject controller, Action<EnemyBehaviorController> callBack) { }

	// RVA: 0x22DB780 Offset: 0x22DB881 VA: 0x22DB780
	private int GetUseEnemyBehaviorCount() { }

	// RVA: 0x22DB840 Offset: 0x22DB941 VA: 0x22DB840
	public void ReleseEnemyBehavior(int id) { }

	// RVA: 0x22DB970 Offset: 0x22DBA71 VA: 0x22DB970
	private void SetupEnemyBehaviorParameter() { }

	// RVA: 0x22DBC00 Offset: 0x22DBD01 VA: 0x22DBC00
	private void SetupEnemyBehavior() { }

	// RVA: 0x22DBCC0 Offset: 0x22DBDC1 VA: 0x22DBCC0
	private GameObject CreateBehaviorGameObject(string name) { }

	// RVA: 0x22DBC10 Offset: 0x22DBD11 VA: 0x22DBC10
	private void LoadEnemyBehavior() { }

	[IteratorStateMachineAttribute] // RVA: 0x19AE10 Offset: 0x19AF11 VA: 0x19AE10
	// RVA: 0x22DBD70 Offset: 0x22DBE71 VA: 0x22DBD70
	public IEnumerator CreateAsyncEnemyBehavior(Character character, Action<EnemyBehaviorController> callBack) { }

	// RVA: 0x22DBE50 Offset: 0x22DBF51 VA: 0x22DBE50
	public void CreateEnemyBehavior(Character character, Action<EnemyBehaviorController> callBack) { }

	// RVA: 0x22DBE80 Offset: 0x22DBF81 VA: 0x22DBE80
	private void AddBossBehavior(int id, BossBehaviorController behavior) { }

	// RVA: 0x22DBF20 Offset: 0x22DC021 VA: 0x22DBF20
	public void RemoveBossBehavior(int id) { }

	// RVA: 0x22DC020 Offset: 0x22DC121 VA: 0x22DC020
	private void RemoveAllBossBehavior() { }

	// RVA: 0x22DC1C0 Offset: 0x22DC2C1 VA: 0x22DC1C0
	private void SetupBossBehavior() { }

	// RVA: 0x22DC240 Offset: 0x22DC341 VA: 0x22DC240
	private void LoadBossBehavior() { }

	[IteratorStateMachineAttribute] // RVA: 0x19AE80 Offset: 0x19AF81 VA: 0x19AE80
	// RVA: 0x22DC2F0 Offset: 0x22DC3F1 VA: 0x22DC2F0
	public IEnumerator CreateAsyncBossBehavior(MonsterControllerBase monsterController, Action<BossBehaviorController> callBack) { }

	// RVA: 0x22DC3D0 Offset: 0x22DC4D1 VA: 0x22DC3D0
	public void CreateBossBehavior(MonsterControllerBase monsterController, Action<BossBehaviorController> callBack) { }

	// RVA: 0x22DC400 Offset: 0x22DC501 VA: 0x22DC400
	private void AddPartnerNPCBehavior(int id, PartnerNPCBehaviorController behavior) { }

	// RVA: 0x22DC4A0 Offset: 0x22DC5A1 VA: 0x22DC4A0
	public PartnerNPCBehaviorController GetPartnerNPCBehavior(int id) { }

	// RVA: 0x22DC540 Offset: 0x22DC641 VA: 0x22DC540
	public void RemovePartnerNPCBehavior(int id) { }

	// RVA: 0x22DC630 Offset: 0x22DC731 VA: 0x22DC630
	private void RemoveAllPartnerBehavior() { }

	// RVA: 0x22DC7D0 Offset: 0x22DC8D1 VA: 0x22DC7D0
	private void SetupPartnerNPCBehavior() { }

	// RVA: 0x22DC850 Offset: 0x22DC951 VA: 0x22DC850
	private void LoadPartnerNPCBehavior() { }

	// RVA: 0x22DC900 Offset: 0x22DCA01 VA: 0x22DC900
	public void CreatePartnerNPCBehavior(Character character, Action<PartnerNPCBehaviorController> callBack) { }

	// RVA: 0x22DCB50 Offset: 0x22DCC51 VA: 0x22DCB50
	public MonsterBehaviorController GetPartnerMonsterBehaviorController(int instanceID) { }

	// RVA: 0x22DCBF0 Offset: 0x22DCCF1 VA: 0x22DCBF0
	public void RemovePartnerMonsterBehavior(int id) { }

	// RVA: 0x22DCCE0 Offset: 0x22DCDE1 VA: 0x22DCCE0
	private void RemoveAllPartnerMonsterBehavior() { }

	// RVA: 0x22DCE80 Offset: 0x22DCF81 VA: 0x22DCE80
	private void SetupPartnerMonsterBehavior() { }

	// RVA: 0x22DCF00 Offset: 0x22DD001 VA: 0x22DCF00
	private void LoadPartnerBehavior() { }

	// RVA: 0x22DCFB0 Offset: 0x22DD0B1 VA: 0x22DCFB0
	public void CreatePartnerMonsterBehavior(Character character, Action<PartnerMonsterBehaviorController> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x19AEF0 Offset: 0x19AFF1 VA: 0x19AEF0
	// RVA: 0x22DD1F0 Offset: 0x22DD2F1 VA: 0x22DD1F0
	public IEnumerator CreateAsyncPetMonsterBehavior(Character character, Action<PartnerMonsterBehaviorController> callBack) { }

	// RVA: 0x22DD2D0 Offset: 0x22DD3D1 VA: 0x22DD2D0
	public void CreatePetMonsterBehavior(Character character, Action<PartnerMonsterBehaviorController> callBack) { }

	// RVA: 0x22DD300 Offset: 0x22DD401 VA: 0x22DD300
	private void SetupPartnerFarmMonsterBehavior() { }

	// RVA: 0x22DD380 Offset: 0x22DD481 VA: 0x22DD380
	private void LoadPartnerFarmBehavior() { }

	// RVA: 0x22DD430 Offset: 0x22DD531 VA: 0x22DD430
	public void CreatePartnerFarmMonsterBehavior(Character character, Action<FarmMonsterBehaviorController> callBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x19AF60 Offset: 0x19B061 VA: 0x19AF60
	// RVA: 0x22DD670 Offset: 0x22DD771 VA: 0x22DD670
	public IEnumerator CreateAsyncSnowmanBehavior(MonsterControllerBase character, Action<EnemyBehaviorController> callBack) { }

	// RVA: 0x22DD750 Offset: 0x22DD851 VA: 0x22DD750
	public void CreateSnowmanBehavior(MonsterControllerBase character, Action<EnemyBehaviorController> callBack) { }

	// RVA: 0x22DD780 Offset: 0x22DD881 VA: 0x22DD780
	private void UpdateBehaviorManager() { }

	// RVA: 0x22DD880 Offset: 0x22DD981 VA: 0x22DD880
	public void OnAfterGameDataLoad() { }

	// RVA: 0x22DD940 Offset: 0x22DDA41 VA: 0x22DD940
	public void OnSceneLoadComplete() { }

	// RVA: 0x22DD950 Offset: 0x22DDA51 VA: 0x22DD950
	public bool IsCompleted() { }

	// RVA: 0x22DD9B0 Offset: 0x22DDAB1 VA: 0x22DD9B0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x22DDBB0 Offset: 0x22DDCB1 VA: 0x22DDBB0
	private void Update() { }

	// RVA: 0x22DDBC0 Offset: 0x22DDCC1 VA: 0x22DDBC0
	private void OnDestroy() { }

	// RVA: 0x22DDCC0 Offset: 0x22DDDC1 VA: 0x22DDCC0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19AFD0 Offset: 0x19B0D1 VA: 0x19AFD0
	// RVA: 0x22DDD80 Offset: 0x22DDE81 VA: 0x22DDD80
	private void <SetupEnemyBehaviorParameter>b__27_0(BehaviorTreeManager.EnemyBehaviorParameter param) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AFE0 Offset: 0x19B0E1 VA: 0x19AFE0
	// RVA: 0x22DDDF0 Offset: 0x22DDEF1 VA: 0x22DDDF0
	private void <LoadEnemyBehavior>b__30_0(AssetHandle<ExternalBehavior> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x19AFF0 Offset: 0x19B0F1 VA: 0x19AFF0
	// RVA: 0x22DDE70 Offset: 0x22DDF71 VA: 0x22DDE70
	private void <LoadBossBehavior>b__39_0(AssetHandle<ExternalBehavior> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B000 Offset: 0x19B101 VA: 0x19B000
	// RVA: 0x22DDEF0 Offset: 0x22DDFF1 VA: 0x22DDEF0
	private void <LoadPartnerNPCBehavior>b__49_0(AssetHandle<ExternalBehavior> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B010 Offset: 0x19B111 VA: 0x19B010
	// RVA: 0x22DDF70 Offset: 0x22DE071 VA: 0x22DDF70
	private void <LoadPartnerBehavior>b__57_0(AssetHandle<ExternalBehavior> handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B020 Offset: 0x19B121 VA: 0x19B020
	// RVA: 0x22DDFF0 Offset: 0x22DE0F1 VA: 0x22DDFF0
	private void <LoadPartnerFarmBehavior>b__63_0(AssetHandle<ExternalBehavior> handle) { }
}


public class FieldTreasureBoxManager : SingletonMonoBehaviour<FieldTreasureBoxManager> // TypeDefIndex: 10514
{
	// Fields
	private const int GateWaitCount = 10;
	private const int DispDistanceSqr = 4096;
	private GameObject[] TreasureBoxPrefabs; // 0x18
	private Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox> UniqueBoxObjectDictonary; // 0x20
	private Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox> RandomBoxObjectDictonary; // 0x28
	private Dictionary<FieldWoodBoxSpawnID, GameObject> WoodBoxObjectDictonary; // 0x30
	private Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox> RewardBoxObjectDictonary; // 0x38
	private FieldUniqueTreasureBoxSpawnDataTableArray _FieldUniqueBoxSpawnDataTableArray; // 0x40
	private FieldRandomTreasureBoxSpawnDataTableArray _FieldRandomBoxSpawnDataTableArray; // 0x48
	private FieldWoodBoxSpawnDataTableArray _FieldWoodBoxSpawnDataTableArray; // 0x50
	private HashSet<FieldUniqueTreasureBoxSpawnID> _ExistUniqueSpawnIDHashSet; // 0x58
	private HashSet<FieldRandomTreasureBoxSpawnID> _ExistRandomSpawnIDHashSet; // 0x60
	private HashSet<FieldWoodBoxSpawnID> _ExistWoodSpawnIDHashSet; // 0x68
	private HashSet<FieldRewardTreasureBoxSpawnID> _ExistRewardSpawnIDHashSet; // 0x70
	private HashSet<FieldUniqueTreasureBoxSpawner> ExistUniqueSpawnerHashSet; // 0x78
	private HashSet<FieldRandomTreasureBoxSpawner> ExistRandomSpawnerHashSet; // 0x80
	private HashSet<FieldRewardTreasureBoxSpawner> ExistRewardSpawnerHashSet; // 0x88
	private HashSet<FieldRandomTreasureBoxSpawner> ExistBossStageRandomSpawnerHashSet; // 0x90
	private ItemDataTable targetItemData; // 0x98
	private int targetMoney; // 0xA0
	public Transform OrderRewardRootTransform; // 0xA8
	private GameObject OrderRewardTreasureBox; // 0xB0

	// Properties
	public bool IsShowHideTreasureBox { get; }
	public HashSet<FieldUniqueTreasureBoxSpawnID> ExistUniqueSpawnIDHashSet { get; set; }
	public HashSet<FieldRandomTreasureBoxSpawnID> ExistRandomSpawnIDHashSet { get; set; }
	public HashSet<FieldWoodBoxSpawnID> ExistWoodSpawnIDHashSet { get; set; }
	public HashSet<FieldRewardTreasureBoxSpawnID> ExistRewardSpawnIDHashSet { get; set; }

	// Methods

	// RVA: 0x1E2E350 Offset: 0x1E2E451 VA: 0x1E2E350
	public bool get_IsShowHideTreasureBox() { }

	// RVA: 0x1E2E3C0 Offset: 0x1E2E4C1 VA: 0x1E2E3C0
	public HashSet<FieldUniqueTreasureBoxSpawnID> get_ExistUniqueSpawnIDHashSet() { }

	// RVA: 0x1E2E3D0 Offset: 0x1E2E4D1 VA: 0x1E2E3D0
	private void set_ExistUniqueSpawnIDHashSet(HashSet<FieldUniqueTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E3E0 Offset: 0x1E2E4E1 VA: 0x1E2E3E0
	public HashSet<FieldRandomTreasureBoxSpawnID> get_ExistRandomSpawnIDHashSet() { }

	// RVA: 0x1E2E3F0 Offset: 0x1E2E4F1 VA: 0x1E2E3F0
	private void set_ExistRandomSpawnIDHashSet(HashSet<FieldRandomTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E400 Offset: 0x1E2E501 VA: 0x1E2E400
	public HashSet<FieldWoodBoxSpawnID> get_ExistWoodSpawnIDHashSet() { }

	// RVA: 0x1E2E410 Offset: 0x1E2E511 VA: 0x1E2E410
	private void set_ExistWoodSpawnIDHashSet(HashSet<FieldWoodBoxSpawnID> value) { }

	// RVA: 0x1E2E420 Offset: 0x1E2E521 VA: 0x1E2E420
	public HashSet<FieldRewardTreasureBoxSpawnID> get_ExistRewardSpawnIDHashSet() { }

	// RVA: 0x1E2E430 Offset: 0x1E2E531 VA: 0x1E2E430
	private void set_ExistRewardSpawnIDHashSet(HashSet<FieldRewardTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E440 Offset: 0x1E2E541 VA: 0x1E2E440
	public static FieldUniqueTreasureBoxSpawnDataTable[] GetUniqueBoxDataTables() { }

	// RVA: 0x1E2E4A0 Offset: 0x1E2E5A1 VA: 0x1E2E4A0
	public static FieldRandomTreasureBoxSpawnDataTable[] GetRandomBoxDataTables() { }

	// RVA: 0x1E2E500 Offset: 0x1E2E601 VA: 0x1E2E500
	public static FieldWoodBoxSpawnDataTable[] GetWoodBoxDataTables() { }

	// RVA: 0x1E2E560 Offset: 0x1E2E661 VA: 0x1E2E560
	public static FieldUniqueTreasureBoxSpawnDataTable GetUniqueBoxDataTable(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E610 Offset: 0x1E2E711 VA: 0x1E2E610
	public static FieldRandomTreasureBoxSpawnDataTable GetRandomBoxDataTable(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E6C0 Offset: 0x1E2E7C1 VA: 0x1E2E6C0
	public static FieldWoodBoxSpawnDataTable GetWoodBoxDataTable(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E770 Offset: 0x1E2E871 VA: 0x1E2E770
	public static FieldUniqueTreasureBoxData GetBoxData(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29010 Offset: 0x1E29111 VA: 0x1E29010
	public static FieldRandomTreasureBoxData GetBoxData(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E8F0 Offset: 0x1E2E9F1 VA: 0x1E2E8F0
	public static FieldWoodBoxData GetBoxData(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B150 Offset: 0x1E2B251 VA: 0x1E2B150
	public static FieldRewardTreasureBoxData GetBoxData(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2EA10 Offset: 0x1E2EB11 VA: 0x1E2EA10
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFAD0 Offset: 0x1AFBD1 VA: 0x1AFAD0
	// RVA: 0x1E2EB00 Offset: 0x1E2EC01 VA: 0x1E2EB00
	public IEnumerator LoadDataTable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFB40 Offset: 0x1AFC41 VA: 0x1AFB40
	// RVA: 0x1E2EB80 Offset: 0x1E2EC81 VA: 0x1E2EB80
	public IEnumerator LoadModelDataAsync() { }

	// RVA: 0x1E2EC60 Offset: 0x1E2ED61 VA: 0x1E2EC60
	private void OnDestroy() { }

	// RVA: 0x1E2EDE0 Offset: 0x1E2EEE1 VA: 0x1E2EDE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E2EE30 Offset: 0x1E2EF31 VA: 0x1E2EE30
	private void Start() { }

	// RVA: 0x1E2EE40 Offset: 0x1E2EF41 VA: 0x1E2EE40
	private void Update() { }

	// RVA: 0x1E2EE50 Offset: 0x1E2EF51 VA: 0x1E2EE50
	private void UpdateMimickMonster() { }

	// RVA: 0x1E2F2A0 Offset: 0x1E2F3A1 VA: 0x1E2F2A0
	private static bool Lottery(int weight) { }

	// RVA: 0x1E2F2E0 Offset: 0x1E2F3E1 VA: 0x1E2F2E0
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E2F400 Offset: 0x1E2F501 VA: 0x1E2F400
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E2F660 Offset: 0x1E2F761 VA: 0x1E2F660
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFBB0 Offset: 0x1AFCB1 VA: 0x1AFBB0
	// RVA: 0x1E2FC80 Offset: 0x1E2FD81 VA: 0x1E2FC80
	private IEnumerator CheckGateTreasureBox() { }

	// RVA: 0x1E2FD30 Offset: 0x1E2FE31 VA: 0x1E2FD30
	private bool ExistGateControllerUniqueBox(GateDataID gateDataID) { }

	// RVA: 0x1E2FE50 Offset: 0x1E2FF51 VA: 0x1E2FE50
	public void RemoveRandomTreasureBox() { }

	// RVA: 0x1E29200 Offset: 0x1E29301 VA: 0x1E29200
	public GameObject InstantiateTreasureBoxPrefab(FieldTreasureBoxType type, Transform parent) { }

	// RVA: 0x1E28370 Offset: 0x1E28471 VA: 0x1E28370
	public void SpawnMonsterBox(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFC20 Offset: 0x1AFD21 VA: 0x1AFC20
	// RVA: 0x1E302A0 Offset: 0x1E303A1 VA: 0x1E302A0
	public IEnumerator SpawnMonsterBoxCoroutine(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E29360 Offset: 0x1E29461 VA: 0x1E29360
	public bool CheckMonsterSpawn(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E30370 Offset: 0x1E30471 VA: 0x1E30370
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29690 Offset: 0x1E29791 VA: 0x1E29690
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30450 Offset: 0x1E30551 VA: 0x1E30450
	public bool AddTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30530 Offset: 0x1E30631 VA: 0x1E30530
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2C110 Offset: 0x1E2C211 VA: 0x1E2C110
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldTreasureBoxDataType boxDataType, int boxSpawnID) { }

	// RVA: 0x1E30610 Offset: 0x1E30711 VA: 0x1E30610
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28240 Offset: 0x1E28341 VA: 0x1E28240
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E306B0 Offset: 0x1E307B1 VA: 0x1E306B0
	public bool RemoveTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2A920 Offset: 0x1E2AA21 VA: 0x1E2A920
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30750 Offset: 0x1E30851 VA: 0x1E30750
	public bool FieldUniqueTreasureBoxSpawnIDExists(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28D50 Offset: 0x1E28E51 VA: 0x1E28D50
	public bool FieldRandomTreasureBoxSpawnIDExists(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E307D0 Offset: 0x1E308D1 VA: 0x1E307D0
	public bool FieldWoodBoxSpawnIDExists(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B030 Offset: 0x1E2B131 VA: 0x1E2B030
	public bool FieldRewardTreasureBoxSpawnIDExists(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30850 Offset: 0x1E30951 VA: 0x1E30850
	public FieldTreasureBox GetTreasureBox(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28DD0 Offset: 0x1E28ED1 VA: 0x1E28DD0
	public FieldTreasureBox GetTreasureBox(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2FBE0 Offset: 0x1E2FCE1 VA: 0x1E2FBE0
	public GameObject GetTreasureBox(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B0B0 Offset: 0x1E2B1B1 VA: 0x1E2B0B0
	public FieldTreasureBox GetTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B8D0 Offset: 0x1E2B9D1 VA: 0x1E2B8D0
	public void AddUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E308F0 Offset: 0x1E309F1 VA: 0x1E308F0
	public void RemoveUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28530 Offset: 0x1E28631 VA: 0x1E28530
	public void AddRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28160 Offset: 0x1E28261 VA: 0x1E28160
	public void RemoveRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E285A0 Offset: 0x1E286A1 VA: 0x1E285A0
	public void AddBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E281D0 Offset: 0x1E282D1 VA: 0x1E281D0
	public void RemoveBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2AA90 Offset: 0x1E2AB91 VA: 0x1E2AA90
	public void AddRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2A8B0 Offset: 0x1E2A9B1 VA: 0x1E2A8B0
	public void RemoveRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2C4A0 Offset: 0x1E2C5A1 VA: 0x1E2C4A0
	public static void SetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28C70 Offset: 0x1E28D71 VA: 0x1E28C70
	public static bool GetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool checkItemFlag = False) { }

	// RVA: 0x1E2C9C0 Offset: 0x1E2CAC1 VA: 0x1E2C9C0
	public static void SetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28E70 Offset: 0x1E28F71 VA: 0x1E28E70
	public static bool GetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id) { }

	// RVA: 0x1E2FB00 Offset: 0x1E2FC01 VA: 0x1E2FB00
	public static void SetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id, bool value) { }

	// RVA: 0x1E30960 Offset: 0x1E30A61 VA: 0x1E30960
	public static bool GetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id) { }

	// RVA: 0x1E28C00 Offset: 0x1E28D01 VA: 0x1E28C00
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E30A50 Offset: 0x1E30B51 VA: 0x1E30A50
	public void OnChangeHideDetectFlag() { }

	// RVA: 0x1E30C60 Offset: 0x1E30D61 VA: 0x1E30C60
	public void OnChangeHideDetectFlag(bool visible) { }

	// RVA: 0x1E30D80 Offset: 0x1E30E81 VA: 0x1E30D80
	public void SetTargetItemName(ItemDataTable targetItemDataTable) { }

	// RVA: 0x1E30D90 Offset: 0x1E30E91 VA: 0x1E30D90
	public string GetTargetItemName() { }

	// RVA: 0x1E30DB0 Offset: 0x1E30EB1 VA: 0x1E30DB0
	public void SetTargetMoney(int value) { }

	// RVA: 0x1E30DC0 Offset: 0x1E30EC1 VA: 0x1E30DC0
	public string GetTargetMoney() { }

	// RVA: 0x1E30DD0 Offset: 0x1E30ED1 VA: 0x1E30DD0
	public void SpawnOrderRewardTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID = 1) { }

	// RVA: 0x1E30F40 Offset: 0x1E31041 VA: 0x1E30F40
	public void SpawnWantedRewardTreasureBox() { }

	// RVA: 0x1E310B0 Offset: 0x1E311B1 VA: 0x1E310B0
	public void SpawnFestivalRewardTreasureBox() { }

	// RVA: 0x1E2AE80 Offset: 0x1E2AF81 VA: 0x1E2AE80
	public static int GetRewardCount(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E2CAA0 Offset: 0x1E2CBA1 VA: 0x1E2CAA0
	public static FieldRewardTreasureBoxData GetRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E31220 Offset: 0x1E31321 VA: 0x1E31220
	public static FieldRewardTreasureBoxData GetOrderRewardData() { }

	// RVA: 0x1E31450 Offset: 0x1E31551 VA: 0x1E31450
	public static FieldRewardTreasureBoxData GetWantedRewardData() { }

	// RVA: 0x1E31570 Offset: 0x1E31671 VA: 0x1E31570
	public static FieldRewardTreasureBoxData GetFestivalRewardData() { }

	// RVA: 0x1E31690 Offset: 0x1E31791 VA: 0x1E31690
	public static void AddOrderReward(int type, int id, int amount, int level, int npcId) { }

	// RVA: 0x1E31760 Offset: 0x1E31861 VA: 0x1E31760
	public static void AddWantedReward(int id, int amount, int level) { }

	// RVA: 0x1E2CC20 Offset: 0x1E2CD21 VA: 0x1E2CC20
	public static void ClearRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E317C0 Offset: 0x1E318C1 VA: 0x1E317C0
	public void RemoveFestivalRewardTreasureBox() { }

	// RVA: 0x1E31930 Offset: 0x1E31A31 VA: 0x1E31930
	public void .ctor() { }
}

public class FieldTreasureBoxManager : SingletonMonoBehaviour<FieldTreasureBoxManager> // TypeDefIndex: 10514
{
	// Fields
	private const int GateWaitCount = 10;
	private const int DispDistanceSqr = 4096;
	private GameObject[] TreasureBoxPrefabs; // 0x18
	private Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox> UniqueBoxObjectDictonary; // 0x20
	private Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox> RandomBoxObjectDictonary; // 0x28
	private Dictionary<FieldWoodBoxSpawnID, GameObject> WoodBoxObjectDictonary; // 0x30
	private Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox> RewardBoxObjectDictonary; // 0x38
	private FieldUniqueTreasureBoxSpawnDataTableArray _FieldUniqueBoxSpawnDataTableArray; // 0x40
	private FieldRandomTreasureBoxSpawnDataTableArray _FieldRandomBoxSpawnDataTableArray; // 0x48
	private FieldWoodBoxSpawnDataTableArray _FieldWoodBoxSpawnDataTableArray; // 0x50
	private HashSet<FieldUniqueTreasureBoxSpawnID> _ExistUniqueSpawnIDHashSet; // 0x58
	private HashSet<FieldRandomTreasureBoxSpawnID> _ExistRandomSpawnIDHashSet; // 0x60
	private HashSet<FieldWoodBoxSpawnID> _ExistWoodSpawnIDHashSet; // 0x68
	private HashSet<FieldRewardTreasureBoxSpawnID> _ExistRewardSpawnIDHashSet; // 0x70
	private HashSet<FieldUniqueTreasureBoxSpawner> ExistUniqueSpawnerHashSet; // 0x78
	private HashSet<FieldRandomTreasureBoxSpawner> ExistRandomSpawnerHashSet; // 0x80
	private HashSet<FieldRewardTreasureBoxSpawner> ExistRewardSpawnerHashSet; // 0x88
	private HashSet<FieldRandomTreasureBoxSpawner> ExistBossStageRandomSpawnerHashSet; // 0x90
	private ItemDataTable targetItemData; // 0x98
	private int targetMoney; // 0xA0
	public Transform OrderRewardRootTransform; // 0xA8
	private GameObject OrderRewardTreasureBox; // 0xB0

	// Properties
	public bool IsShowHideTreasureBox { get; }
	public HashSet<FieldUniqueTreasureBoxSpawnID> ExistUniqueSpawnIDHashSet { get; set; }
	public HashSet<FieldRandomTreasureBoxSpawnID> ExistRandomSpawnIDHashSet { get; set; }
	public HashSet<FieldWoodBoxSpawnID> ExistWoodSpawnIDHashSet { get; set; }
	public HashSet<FieldRewardTreasureBoxSpawnID> ExistRewardSpawnIDHashSet { get; set; }

	// Methods

	// RVA: 0x1E2E350 Offset: 0x1E2E451 VA: 0x1E2E350
	public bool get_IsShowHideTreasureBox() { }

	// RVA: 0x1E2E3C0 Offset: 0x1E2E4C1 VA: 0x1E2E3C0
	public HashSet<FieldUniqueTreasureBoxSpawnID> get_ExistUniqueSpawnIDHashSet() { }

	// RVA: 0x1E2E3D0 Offset: 0x1E2E4D1 VA: 0x1E2E3D0
	private void set_ExistUniqueSpawnIDHashSet(HashSet<FieldUniqueTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E3E0 Offset: 0x1E2E4E1 VA: 0x1E2E3E0
	public HashSet<FieldRandomTreasureBoxSpawnID> get_ExistRandomSpawnIDHashSet() { }

	// RVA: 0x1E2E3F0 Offset: 0x1E2E4F1 VA: 0x1E2E3F0
	private void set_ExistRandomSpawnIDHashSet(HashSet<FieldRandomTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E400 Offset: 0x1E2E501 VA: 0x1E2E400
	public HashSet<FieldWoodBoxSpawnID> get_ExistWoodSpawnIDHashSet() { }

	// RVA: 0x1E2E410 Offset: 0x1E2E511 VA: 0x1E2E410
	private void set_ExistWoodSpawnIDHashSet(HashSet<FieldWoodBoxSpawnID> value) { }

	// RVA: 0x1E2E420 Offset: 0x1E2E521 VA: 0x1E2E420
	public HashSet<FieldRewardTreasureBoxSpawnID> get_ExistRewardSpawnIDHashSet() { }

	// RVA: 0x1E2E430 Offset: 0x1E2E531 VA: 0x1E2E430
	private void set_ExistRewardSpawnIDHashSet(HashSet<FieldRewardTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E440 Offset: 0x1E2E541 VA: 0x1E2E440
	public static FieldUniqueTreasureBoxSpawnDataTable[] GetUniqueBoxDataTables() { }

	// RVA: 0x1E2E4A0 Offset: 0x1E2E5A1 VA: 0x1E2E4A0
	public static FieldRandomTreasureBoxSpawnDataTable[] GetRandomBoxDataTables() { }

	// RVA: 0x1E2E500 Offset: 0x1E2E601 VA: 0x1E2E500
	public static FieldWoodBoxSpawnDataTable[] GetWoodBoxDataTables() { }

	// RVA: 0x1E2E560 Offset: 0x1E2E661 VA: 0x1E2E560
	public static FieldUniqueTreasureBoxSpawnDataTable GetUniqueBoxDataTable(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E610 Offset: 0x1E2E711 VA: 0x1E2E610
	public static FieldRandomTreasureBoxSpawnDataTable GetRandomBoxDataTable(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E6C0 Offset: 0x1E2E7C1 VA: 0x1E2E6C0
	public static FieldWoodBoxSpawnDataTable GetWoodBoxDataTable(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E770 Offset: 0x1E2E871 VA: 0x1E2E770
	public static FieldUniqueTreasureBoxData GetBoxData(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29010 Offset: 0x1E29111 VA: 0x1E29010
	public static FieldRandomTreasureBoxData GetBoxData(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E8F0 Offset: 0x1E2E9F1 VA: 0x1E2E8F0
	public static FieldWoodBoxData GetBoxData(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B150 Offset: 0x1E2B251 VA: 0x1E2B150
	public static FieldRewardTreasureBoxData GetBoxData(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2EA10 Offset: 0x1E2EB11 VA: 0x1E2EA10
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFAD0 Offset: 0x1AFBD1 VA: 0x1AFAD0
	// RVA: 0x1E2EB00 Offset: 0x1E2EC01 VA: 0x1E2EB00
	public IEnumerator LoadDataTable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFB40 Offset: 0x1AFC41 VA: 0x1AFB40
	// RVA: 0x1E2EB80 Offset: 0x1E2EC81 VA: 0x1E2EB80
	public IEnumerator LoadModelDataAsync() { }

	// RVA: 0x1E2EC60 Offset: 0x1E2ED61 VA: 0x1E2EC60
	private void OnDestroy() { }

	// RVA: 0x1E2EDE0 Offset: 0x1E2EEE1 VA: 0x1E2EDE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E2EE30 Offset: 0x1E2EF31 VA: 0x1E2EE30
	private void Start() { }

	// RVA: 0x1E2EE40 Offset: 0x1E2EF41 VA: 0x1E2EE40
	private void Update() { }

	// RVA: 0x1E2EE50 Offset: 0x1E2EF51 VA: 0x1E2EE50
	private void UpdateMimickMonster() { }

	// RVA: 0x1E2F2A0 Offset: 0x1E2F3A1 VA: 0x1E2F2A0
	private static bool Lottery(int weight) { }

	// RVA: 0x1E2F2E0 Offset: 0x1E2F3E1 VA: 0x1E2F2E0
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E2F400 Offset: 0x1E2F501 VA: 0x1E2F400
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E2F660 Offset: 0x1E2F761 VA: 0x1E2F660
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFBB0 Offset: 0x1AFCB1 VA: 0x1AFBB0
	// RVA: 0x1E2FC80 Offset: 0x1E2FD81 VA: 0x1E2FC80
	private IEnumerator CheckGateTreasureBox() { }

	// RVA: 0x1E2FD30 Offset: 0x1E2FE31 VA: 0x1E2FD30
	private bool ExistGateControllerUniqueBox(GateDataID gateDataID) { }

	// RVA: 0x1E2FE50 Offset: 0x1E2FF51 VA: 0x1E2FE50
	public void RemoveRandomTreasureBox() { }

	// RVA: 0x1E29200 Offset: 0x1E29301 VA: 0x1E29200
	public GameObject InstantiateTreasureBoxPrefab(FieldTreasureBoxType type, Transform parent) { }

	// RVA: 0x1E28370 Offset: 0x1E28471 VA: 0x1E28370
	public void SpawnMonsterBox(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFC20 Offset: 0x1AFD21 VA: 0x1AFC20
	// RVA: 0x1E302A0 Offset: 0x1E303A1 VA: 0x1E302A0
	public IEnumerator SpawnMonsterBoxCoroutine(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E29360 Offset: 0x1E29461 VA: 0x1E29360
	public bool CheckMonsterSpawn(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E30370 Offset: 0x1E30471 VA: 0x1E30370
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29690 Offset: 0x1E29791 VA: 0x1E29690
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30450 Offset: 0x1E30551 VA: 0x1E30450
	public bool AddTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30530 Offset: 0x1E30631 VA: 0x1E30530
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2C110 Offset: 0x1E2C211 VA: 0x1E2C110
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldTreasureBoxDataType boxDataType, int boxSpawnID) { }

	// RVA: 0x1E30610 Offset: 0x1E30711 VA: 0x1E30610
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28240 Offset: 0x1E28341 VA: 0x1E28240
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E306B0 Offset: 0x1E307B1 VA: 0x1E306B0
	public bool RemoveTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2A920 Offset: 0x1E2AA21 VA: 0x1E2A920
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30750 Offset: 0x1E30851 VA: 0x1E30750
	public bool FieldUniqueTreasureBoxSpawnIDExists(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28D50 Offset: 0x1E28E51 VA: 0x1E28D50
	public bool FieldRandomTreasureBoxSpawnIDExists(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E307D0 Offset: 0x1E308D1 VA: 0x1E307D0
	public bool FieldWoodBoxSpawnIDExists(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B030 Offset: 0x1E2B131 VA: 0x1E2B030
	public bool FieldRewardTreasureBoxSpawnIDExists(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30850 Offset: 0x1E30951 VA: 0x1E30850
	public FieldTreasureBox GetTreasureBox(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28DD0 Offset: 0x1E28ED1 VA: 0x1E28DD0
	public FieldTreasureBox GetTreasureBox(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2FBE0 Offset: 0x1E2FCE1 VA: 0x1E2FBE0
	public GameObject GetTreasureBox(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B0B0 Offset: 0x1E2B1B1 VA: 0x1E2B0B0
	public FieldTreasureBox GetTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B8D0 Offset: 0x1E2B9D1 VA: 0x1E2B8D0
	public void AddUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E308F0 Offset: 0x1E309F1 VA: 0x1E308F0
	public void RemoveUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28530 Offset: 0x1E28631 VA: 0x1E28530
	public void AddRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28160 Offset: 0x1E28261 VA: 0x1E28160
	public void RemoveRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E285A0 Offset: 0x1E286A1 VA: 0x1E285A0
	public void AddBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E281D0 Offset: 0x1E282D1 VA: 0x1E281D0
	public void RemoveBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2AA90 Offset: 0x1E2AB91 VA: 0x1E2AA90
	public void AddRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2A8B0 Offset: 0x1E2A9B1 VA: 0x1E2A8B0
	public void RemoveRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2C4A0 Offset: 0x1E2C5A1 VA: 0x1E2C4A0
	public static void SetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28C70 Offset: 0x1E28D71 VA: 0x1E28C70
	public static bool GetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool checkItemFlag = False) { }

	// RVA: 0x1E2C9C0 Offset: 0x1E2CAC1 VA: 0x1E2C9C0
	public static void SetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28E70 Offset: 0x1E28F71 VA: 0x1E28E70
	public static bool GetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id) { }

	// RVA: 0x1E2FB00 Offset: 0x1E2FC01 VA: 0x1E2FB00
	public static void SetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id, bool value) { }

	// RVA: 0x1E30960 Offset: 0x1E30A61 VA: 0x1E30960
	public static bool GetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id) { }

	// RVA: 0x1E28C00 Offset: 0x1E28D01 VA: 0x1E28C00
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E30A50 Offset: 0x1E30B51 VA: 0x1E30A50
	public void OnChangeHideDetectFlag() { }

	// RVA: 0x1E30C60 Offset: 0x1E30D61 VA: 0x1E30C60
	public void OnChangeHideDetectFlag(bool visible) { }

	// RVA: 0x1E30D80 Offset: 0x1E30E81 VA: 0x1E30D80
	public void SetTargetItemName(ItemDataTable targetItemDataTable) { }

	// RVA: 0x1E30D90 Offset: 0x1E30E91 VA: 0x1E30D90
	public string GetTargetItemName() { }

	// RVA: 0x1E30DB0 Offset: 0x1E30EB1 VA: 0x1E30DB0
	public void SetTargetMoney(int value) { }

	// RVA: 0x1E30DC0 Offset: 0x1E30EC1 VA: 0x1E30DC0
	public string GetTargetMoney() { }

	// RVA: 0x1E30DD0 Offset: 0x1E30ED1 VA: 0x1E30DD0
	public void SpawnOrderRewardTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID = 1) { }

	// RVA: 0x1E30F40 Offset: 0x1E31041 VA: 0x1E30F40
	public void SpawnWantedRewardTreasureBox() { }

	// RVA: 0x1E310B0 Offset: 0x1E311B1 VA: 0x1E310B0
	public void SpawnFestivalRewardTreasureBox() { }

	// RVA: 0x1E2AE80 Offset: 0x1E2AF81 VA: 0x1E2AE80
	public static int GetRewardCount(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E2CAA0 Offset: 0x1E2CBA1 VA: 0x1E2CAA0
	public static FieldRewardTreasureBoxData GetRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E31220 Offset: 0x1E31321 VA: 0x1E31220
	public static FieldRewardTreasureBoxData GetOrderRewardData() { }

	// RVA: 0x1E31450 Offset: 0x1E31551 VA: 0x1E31450
	public static FieldRewardTreasureBoxData GetWantedRewardData() { }

	// RVA: 0x1E31570 Offset: 0x1E31671 VA: 0x1E31570
	public static FieldRewardTreasureBoxData GetFestivalRewardData() { }

	// RVA: 0x1E31690 Offset: 0x1E31791 VA: 0x1E31690
	public static void AddOrderReward(int type, int id, int amount, int level, int npcId) { }

	// RVA: 0x1E31760 Offset: 0x1E31861 VA: 0x1E31760
	public static void AddWantedReward(int id, int amount, int level) { }

	// RVA: 0x1E2CC20 Offset: 0x1E2CD21 VA: 0x1E2CC20
	public static void ClearRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E317C0 Offset: 0x1E318C1 VA: 0x1E317C0
	public void RemoveFestivalRewardTreasureBox() { }

	// RVA: 0x1E31930 Offset: 0x1E31A31 VA: 0x1E31930
	public void .ctor() { }
}

public class FieldTreasureBoxManager : SingletonMonoBehaviour<FieldTreasureBoxManager> // TypeDefIndex: 10514
{
	// Fields
	private const int GateWaitCount = 10;
	private const int DispDistanceSqr = 4096;
	private GameObject[] TreasureBoxPrefabs; // 0x18
	private Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox> UniqueBoxObjectDictonary; // 0x20
	private Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox> RandomBoxObjectDictonary; // 0x28
	private Dictionary<FieldWoodBoxSpawnID, GameObject> WoodBoxObjectDictonary; // 0x30
	private Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox> RewardBoxObjectDictonary; // 0x38
	private FieldUniqueTreasureBoxSpawnDataTableArray _FieldUniqueBoxSpawnDataTableArray; // 0x40
	private FieldRandomTreasureBoxSpawnDataTableArray _FieldRandomBoxSpawnDataTableArray; // 0x48
	private FieldWoodBoxSpawnDataTableArray _FieldWoodBoxSpawnDataTableArray; // 0x50
	private HashSet<FieldUniqueTreasureBoxSpawnID> _ExistUniqueSpawnIDHashSet; // 0x58
	private HashSet<FieldRandomTreasureBoxSpawnID> _ExistRandomSpawnIDHashSet; // 0x60
	private HashSet<FieldWoodBoxSpawnID> _ExistWoodSpawnIDHashSet; // 0x68
	private HashSet<FieldRewardTreasureBoxSpawnID> _ExistRewardSpawnIDHashSet; // 0x70
	private HashSet<FieldUniqueTreasureBoxSpawner> ExistUniqueSpawnerHashSet; // 0x78
	private HashSet<FieldRandomTreasureBoxSpawner> ExistRandomSpawnerHashSet; // 0x80
	private HashSet<FieldRewardTreasureBoxSpawner> ExistRewardSpawnerHashSet; // 0x88
	private HashSet<FieldRandomTreasureBoxSpawner> ExistBossStageRandomSpawnerHashSet; // 0x90
	private ItemDataTable targetItemData; // 0x98
	private int targetMoney; // 0xA0
	public Transform OrderRewardRootTransform; // 0xA8
	private GameObject OrderRewardTreasureBox; // 0xB0

	// Properties
	public bool IsShowHideTreasureBox { get; }
	public HashSet<FieldUniqueTreasureBoxSpawnID> ExistUniqueSpawnIDHashSet { get; set; }
	public HashSet<FieldRandomTreasureBoxSpawnID> ExistRandomSpawnIDHashSet { get; set; }
	public HashSet<FieldWoodBoxSpawnID> ExistWoodSpawnIDHashSet { get; set; }
	public HashSet<FieldRewardTreasureBoxSpawnID> ExistRewardSpawnIDHashSet { get; set; }

	// Methods

	// RVA: 0x1E2E350 Offset: 0x1E2E451 VA: 0x1E2E350
	public bool get_IsShowHideTreasureBox() { }

	// RVA: 0x1E2E3C0 Offset: 0x1E2E4C1 VA: 0x1E2E3C0
	public HashSet<FieldUniqueTreasureBoxSpawnID> get_ExistUniqueSpawnIDHashSet() { }

	// RVA: 0x1E2E3D0 Offset: 0x1E2E4D1 VA: 0x1E2E3D0
	private void set_ExistUniqueSpawnIDHashSet(HashSet<FieldUniqueTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E3E0 Offset: 0x1E2E4E1 VA: 0x1E2E3E0
	public HashSet<FieldRandomTreasureBoxSpawnID> get_ExistRandomSpawnIDHashSet() { }

	// RVA: 0x1E2E3F0 Offset: 0x1E2E4F1 VA: 0x1E2E3F0
	private void set_ExistRandomSpawnIDHashSet(HashSet<FieldRandomTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E400 Offset: 0x1E2E501 VA: 0x1E2E400
	public HashSet<FieldWoodBoxSpawnID> get_ExistWoodSpawnIDHashSet() { }

	// RVA: 0x1E2E410 Offset: 0x1E2E511 VA: 0x1E2E410
	private void set_ExistWoodSpawnIDHashSet(HashSet<FieldWoodBoxSpawnID> value) { }

	// RVA: 0x1E2E420 Offset: 0x1E2E521 VA: 0x1E2E420
	public HashSet<FieldRewardTreasureBoxSpawnID> get_ExistRewardSpawnIDHashSet() { }

	// RVA: 0x1E2E430 Offset: 0x1E2E531 VA: 0x1E2E430
	private void set_ExistRewardSpawnIDHashSet(HashSet<FieldRewardTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E440 Offset: 0x1E2E541 VA: 0x1E2E440
	public static FieldUniqueTreasureBoxSpawnDataTable[] GetUniqueBoxDataTables() { }

	// RVA: 0x1E2E4A0 Offset: 0x1E2E5A1 VA: 0x1E2E4A0
	public static FieldRandomTreasureBoxSpawnDataTable[] GetRandomBoxDataTables() { }

	// RVA: 0x1E2E500 Offset: 0x1E2E601 VA: 0x1E2E500
	public static FieldWoodBoxSpawnDataTable[] GetWoodBoxDataTables() { }

	// RVA: 0x1E2E560 Offset: 0x1E2E661 VA: 0x1E2E560
	public static FieldUniqueTreasureBoxSpawnDataTable GetUniqueBoxDataTable(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E610 Offset: 0x1E2E711 VA: 0x1E2E610
	public static FieldRandomTreasureBoxSpawnDataTable GetRandomBoxDataTable(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E6C0 Offset: 0x1E2E7C1 VA: 0x1E2E6C0
	public static FieldWoodBoxSpawnDataTable GetWoodBoxDataTable(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E770 Offset: 0x1E2E871 VA: 0x1E2E770
	public static FieldUniqueTreasureBoxData GetBoxData(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29010 Offset: 0x1E29111 VA: 0x1E29010
	public static FieldRandomTreasureBoxData GetBoxData(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E8F0 Offset: 0x1E2E9F1 VA: 0x1E2E8F0
	public static FieldWoodBoxData GetBoxData(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B150 Offset: 0x1E2B251 VA: 0x1E2B150
	public static FieldRewardTreasureBoxData GetBoxData(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2EA10 Offset: 0x1E2EB11 VA: 0x1E2EA10
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFAD0 Offset: 0x1AFBD1 VA: 0x1AFAD0
	// RVA: 0x1E2EB00 Offset: 0x1E2EC01 VA: 0x1E2EB00
	public IEnumerator LoadDataTable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFB40 Offset: 0x1AFC41 VA: 0x1AFB40
	// RVA: 0x1E2EB80 Offset: 0x1E2EC81 VA: 0x1E2EB80
	public IEnumerator LoadModelDataAsync() { }

	// RVA: 0x1E2EC60 Offset: 0x1E2ED61 VA: 0x1E2EC60
	private void OnDestroy() { }

	// RVA: 0x1E2EDE0 Offset: 0x1E2EEE1 VA: 0x1E2EDE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E2EE30 Offset: 0x1E2EF31 VA: 0x1E2EE30
	private void Start() { }

	// RVA: 0x1E2EE40 Offset: 0x1E2EF41 VA: 0x1E2EE40
	private void Update() { }

	// RVA: 0x1E2EE50 Offset: 0x1E2EF51 VA: 0x1E2EE50
	private void UpdateMimickMonster() { }

	// RVA: 0x1E2F2A0 Offset: 0x1E2F3A1 VA: 0x1E2F2A0
	private static bool Lottery(int weight) { }

	// RVA: 0x1E2F2E0 Offset: 0x1E2F3E1 VA: 0x1E2F2E0
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E2F400 Offset: 0x1E2F501 VA: 0x1E2F400
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E2F660 Offset: 0x1E2F761 VA: 0x1E2F660
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFBB0 Offset: 0x1AFCB1 VA: 0x1AFBB0
	// RVA: 0x1E2FC80 Offset: 0x1E2FD81 VA: 0x1E2FC80
	private IEnumerator CheckGateTreasureBox() { }

	// RVA: 0x1E2FD30 Offset: 0x1E2FE31 VA: 0x1E2FD30
	private bool ExistGateControllerUniqueBox(GateDataID gateDataID) { }

	// RVA: 0x1E2FE50 Offset: 0x1E2FF51 VA: 0x1E2FE50
	public void RemoveRandomTreasureBox() { }

	// RVA: 0x1E29200 Offset: 0x1E29301 VA: 0x1E29200
	public GameObject InstantiateTreasureBoxPrefab(FieldTreasureBoxType type, Transform parent) { }

	// RVA: 0x1E28370 Offset: 0x1E28471 VA: 0x1E28370
	public void SpawnMonsterBox(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFC20 Offset: 0x1AFD21 VA: 0x1AFC20
	// RVA: 0x1E302A0 Offset: 0x1E303A1 VA: 0x1E302A0
	public IEnumerator SpawnMonsterBoxCoroutine(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E29360 Offset: 0x1E29461 VA: 0x1E29360
	public bool CheckMonsterSpawn(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E30370 Offset: 0x1E30471 VA: 0x1E30370
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29690 Offset: 0x1E29791 VA: 0x1E29690
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30450 Offset: 0x1E30551 VA: 0x1E30450
	public bool AddTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30530 Offset: 0x1E30631 VA: 0x1E30530
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2C110 Offset: 0x1E2C211 VA: 0x1E2C110
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldTreasureBoxDataType boxDataType, int boxSpawnID) { }

	// RVA: 0x1E30610 Offset: 0x1E30711 VA: 0x1E30610
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28240 Offset: 0x1E28341 VA: 0x1E28240
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E306B0 Offset: 0x1E307B1 VA: 0x1E306B0
	public bool RemoveTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2A920 Offset: 0x1E2AA21 VA: 0x1E2A920
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30750 Offset: 0x1E30851 VA: 0x1E30750
	public bool FieldUniqueTreasureBoxSpawnIDExists(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28D50 Offset: 0x1E28E51 VA: 0x1E28D50
	public bool FieldRandomTreasureBoxSpawnIDExists(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E307D0 Offset: 0x1E308D1 VA: 0x1E307D0
	public bool FieldWoodBoxSpawnIDExists(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B030 Offset: 0x1E2B131 VA: 0x1E2B030
	public bool FieldRewardTreasureBoxSpawnIDExists(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30850 Offset: 0x1E30951 VA: 0x1E30850
	public FieldTreasureBox GetTreasureBox(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28DD0 Offset: 0x1E28ED1 VA: 0x1E28DD0
	public FieldTreasureBox GetTreasureBox(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2FBE0 Offset: 0x1E2FCE1 VA: 0x1E2FBE0
	public GameObject GetTreasureBox(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B0B0 Offset: 0x1E2B1B1 VA: 0x1E2B0B0
	public FieldTreasureBox GetTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B8D0 Offset: 0x1E2B9D1 VA: 0x1E2B8D0
	public void AddUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E308F0 Offset: 0x1E309F1 VA: 0x1E308F0
	public void RemoveUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28530 Offset: 0x1E28631 VA: 0x1E28530
	public void AddRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28160 Offset: 0x1E28261 VA: 0x1E28160
	public void RemoveRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E285A0 Offset: 0x1E286A1 VA: 0x1E285A0
	public void AddBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E281D0 Offset: 0x1E282D1 VA: 0x1E281D0
	public void RemoveBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2AA90 Offset: 0x1E2AB91 VA: 0x1E2AA90
	public void AddRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2A8B0 Offset: 0x1E2A9B1 VA: 0x1E2A8B0
	public void RemoveRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2C4A0 Offset: 0x1E2C5A1 VA: 0x1E2C4A0
	public static void SetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28C70 Offset: 0x1E28D71 VA: 0x1E28C70
	public static bool GetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool checkItemFlag = False) { }

	// RVA: 0x1E2C9C0 Offset: 0x1E2CAC1 VA: 0x1E2C9C0
	public static void SetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28E70 Offset: 0x1E28F71 VA: 0x1E28E70
	public static bool GetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id) { }

	// RVA: 0x1E2FB00 Offset: 0x1E2FC01 VA: 0x1E2FB00
	public static void SetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id, bool value) { }

	// RVA: 0x1E30960 Offset: 0x1E30A61 VA: 0x1E30960
	public static bool GetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id) { }

	// RVA: 0x1E28C00 Offset: 0x1E28D01 VA: 0x1E28C00
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E30A50 Offset: 0x1E30B51 VA: 0x1E30A50
	public void OnChangeHideDetectFlag() { }

	// RVA: 0x1E30C60 Offset: 0x1E30D61 VA: 0x1E30C60
	public void OnChangeHideDetectFlag(bool visible) { }

	// RVA: 0x1E30D80 Offset: 0x1E30E81 VA: 0x1E30D80
	public void SetTargetItemName(ItemDataTable targetItemDataTable) { }

	// RVA: 0x1E30D90 Offset: 0x1E30E91 VA: 0x1E30D90
	public string GetTargetItemName() { }

	// RVA: 0x1E30DB0 Offset: 0x1E30EB1 VA: 0x1E30DB0
	public void SetTargetMoney(int value) { }

	// RVA: 0x1E30DC0 Offset: 0x1E30EC1 VA: 0x1E30DC0
	public string GetTargetMoney() { }

	// RVA: 0x1E30DD0 Offset: 0x1E30ED1 VA: 0x1E30DD0
	public void SpawnOrderRewardTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID = 1) { }

	// RVA: 0x1E30F40 Offset: 0x1E31041 VA: 0x1E30F40
	public void SpawnWantedRewardTreasureBox() { }

	// RVA: 0x1E310B0 Offset: 0x1E311B1 VA: 0x1E310B0
	public void SpawnFestivalRewardTreasureBox() { }

	// RVA: 0x1E2AE80 Offset: 0x1E2AF81 VA: 0x1E2AE80
	public static int GetRewardCount(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E2CAA0 Offset: 0x1E2CBA1 VA: 0x1E2CAA0
	public static FieldRewardTreasureBoxData GetRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E31220 Offset: 0x1E31321 VA: 0x1E31220
	public static FieldRewardTreasureBoxData GetOrderRewardData() { }

	// RVA: 0x1E31450 Offset: 0x1E31551 VA: 0x1E31450
	public static FieldRewardTreasureBoxData GetWantedRewardData() { }

	// RVA: 0x1E31570 Offset: 0x1E31671 VA: 0x1E31570
	public static FieldRewardTreasureBoxData GetFestivalRewardData() { }

	// RVA: 0x1E31690 Offset: 0x1E31791 VA: 0x1E31690
	public static void AddOrderReward(int type, int id, int amount, int level, int npcId) { }

	// RVA: 0x1E31760 Offset: 0x1E31861 VA: 0x1E31760
	public static void AddWantedReward(int id, int amount, int level) { }

	// RVA: 0x1E2CC20 Offset: 0x1E2CD21 VA: 0x1E2CC20
	public static void ClearRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E317C0 Offset: 0x1E318C1 VA: 0x1E317C0
	public void RemoveFestivalRewardTreasureBox() { }

	// RVA: 0x1E31930 Offset: 0x1E31A31 VA: 0x1E31930
	public void .ctor() { }
}

public class FieldTreasureBoxManager : SingletonMonoBehaviour<FieldTreasureBoxManager> // TypeDefIndex: 10514
{
	// Fields
	private const int GateWaitCount = 10;
	private const int DispDistanceSqr = 4096;
	private GameObject[] TreasureBoxPrefabs; // 0x18
	private Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox> UniqueBoxObjectDictonary; // 0x20
	private Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox> RandomBoxObjectDictonary; // 0x28
	private Dictionary<FieldWoodBoxSpawnID, GameObject> WoodBoxObjectDictonary; // 0x30
	private Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox> RewardBoxObjectDictonary; // 0x38
	private FieldUniqueTreasureBoxSpawnDataTableArray _FieldUniqueBoxSpawnDataTableArray; // 0x40
	private FieldRandomTreasureBoxSpawnDataTableArray _FieldRandomBoxSpawnDataTableArray; // 0x48
	private FieldWoodBoxSpawnDataTableArray _FieldWoodBoxSpawnDataTableArray; // 0x50
	private HashSet<FieldUniqueTreasureBoxSpawnID> _ExistUniqueSpawnIDHashSet; // 0x58
	private HashSet<FieldRandomTreasureBoxSpawnID> _ExistRandomSpawnIDHashSet; // 0x60
	private HashSet<FieldWoodBoxSpawnID> _ExistWoodSpawnIDHashSet; // 0x68
	private HashSet<FieldRewardTreasureBoxSpawnID> _ExistRewardSpawnIDHashSet; // 0x70
	private HashSet<FieldUniqueTreasureBoxSpawner> ExistUniqueSpawnerHashSet; // 0x78
	private HashSet<FieldRandomTreasureBoxSpawner> ExistRandomSpawnerHashSet; // 0x80
	private HashSet<FieldRewardTreasureBoxSpawner> ExistRewardSpawnerHashSet; // 0x88
	private HashSet<FieldRandomTreasureBoxSpawner> ExistBossStageRandomSpawnerHashSet; // 0x90
	private ItemDataTable targetItemData; // 0x98
	private int targetMoney; // 0xA0
	public Transform OrderRewardRootTransform; // 0xA8
	private GameObject OrderRewardTreasureBox; // 0xB0

	// Properties
	public bool IsShowHideTreasureBox { get; }
	public HashSet<FieldUniqueTreasureBoxSpawnID> ExistUniqueSpawnIDHashSet { get; set; }
	public HashSet<FieldRandomTreasureBoxSpawnID> ExistRandomSpawnIDHashSet { get; set; }
	public HashSet<FieldWoodBoxSpawnID> ExistWoodSpawnIDHashSet { get; set; }
	public HashSet<FieldRewardTreasureBoxSpawnID> ExistRewardSpawnIDHashSet { get; set; }

	// Methods

	// RVA: 0x1E2E350 Offset: 0x1E2E451 VA: 0x1E2E350
	public bool get_IsShowHideTreasureBox() { }

	// RVA: 0x1E2E3C0 Offset: 0x1E2E4C1 VA: 0x1E2E3C0
	public HashSet<FieldUniqueTreasureBoxSpawnID> get_ExistUniqueSpawnIDHashSet() { }

	// RVA: 0x1E2E3D0 Offset: 0x1E2E4D1 VA: 0x1E2E3D0
	private void set_ExistUniqueSpawnIDHashSet(HashSet<FieldUniqueTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E3E0 Offset: 0x1E2E4E1 VA: 0x1E2E3E0
	public HashSet<FieldRandomTreasureBoxSpawnID> get_ExistRandomSpawnIDHashSet() { }

	// RVA: 0x1E2E3F0 Offset: 0x1E2E4F1 VA: 0x1E2E3F0
	private void set_ExistRandomSpawnIDHashSet(HashSet<FieldRandomTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E400 Offset: 0x1E2E501 VA: 0x1E2E400
	public HashSet<FieldWoodBoxSpawnID> get_ExistWoodSpawnIDHashSet() { }

	// RVA: 0x1E2E410 Offset: 0x1E2E511 VA: 0x1E2E410
	private void set_ExistWoodSpawnIDHashSet(HashSet<FieldWoodBoxSpawnID> value) { }

	// RVA: 0x1E2E420 Offset: 0x1E2E521 VA: 0x1E2E420
	public HashSet<FieldRewardTreasureBoxSpawnID> get_ExistRewardSpawnIDHashSet() { }

	// RVA: 0x1E2E430 Offset: 0x1E2E531 VA: 0x1E2E430
	private void set_ExistRewardSpawnIDHashSet(HashSet<FieldRewardTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E440 Offset: 0x1E2E541 VA: 0x1E2E440
	public static FieldUniqueTreasureBoxSpawnDataTable[] GetUniqueBoxDataTables() { }

	// RVA: 0x1E2E4A0 Offset: 0x1E2E5A1 VA: 0x1E2E4A0
	public static FieldRandomTreasureBoxSpawnDataTable[] GetRandomBoxDataTables() { }

	// RVA: 0x1E2E500 Offset: 0x1E2E601 VA: 0x1E2E500
	public static FieldWoodBoxSpawnDataTable[] GetWoodBoxDataTables() { }

	// RVA: 0x1E2E560 Offset: 0x1E2E661 VA: 0x1E2E560
	public static FieldUniqueTreasureBoxSpawnDataTable GetUniqueBoxDataTable(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E610 Offset: 0x1E2E711 VA: 0x1E2E610
	public static FieldRandomTreasureBoxSpawnDataTable GetRandomBoxDataTable(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E6C0 Offset: 0x1E2E7C1 VA: 0x1E2E6C0
	public static FieldWoodBoxSpawnDataTable GetWoodBoxDataTable(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E770 Offset: 0x1E2E871 VA: 0x1E2E770
	public static FieldUniqueTreasureBoxData GetBoxData(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29010 Offset: 0x1E29111 VA: 0x1E29010
	public static FieldRandomTreasureBoxData GetBoxData(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E8F0 Offset: 0x1E2E9F1 VA: 0x1E2E8F0
	public static FieldWoodBoxData GetBoxData(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B150 Offset: 0x1E2B251 VA: 0x1E2B150
	public static FieldRewardTreasureBoxData GetBoxData(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2EA10 Offset: 0x1E2EB11 VA: 0x1E2EA10
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFAD0 Offset: 0x1AFBD1 VA: 0x1AFAD0
	// RVA: 0x1E2EB00 Offset: 0x1E2EC01 VA: 0x1E2EB00
	public IEnumerator LoadDataTable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFB40 Offset: 0x1AFC41 VA: 0x1AFB40
	// RVA: 0x1E2EB80 Offset: 0x1E2EC81 VA: 0x1E2EB80
	public IEnumerator LoadModelDataAsync() { }

	// RVA: 0x1E2EC60 Offset: 0x1E2ED61 VA: 0x1E2EC60
	private void OnDestroy() { }

	// RVA: 0x1E2EDE0 Offset: 0x1E2EEE1 VA: 0x1E2EDE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E2EE30 Offset: 0x1E2EF31 VA: 0x1E2EE30
	private void Start() { }

	// RVA: 0x1E2EE40 Offset: 0x1E2EF41 VA: 0x1E2EE40
	private void Update() { }

	// RVA: 0x1E2EE50 Offset: 0x1E2EF51 VA: 0x1E2EE50
	private void UpdateMimickMonster() { }

	// RVA: 0x1E2F2A0 Offset: 0x1E2F3A1 VA: 0x1E2F2A0
	private static bool Lottery(int weight) { }

	// RVA: 0x1E2F2E0 Offset: 0x1E2F3E1 VA: 0x1E2F2E0
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E2F400 Offset: 0x1E2F501 VA: 0x1E2F400
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E2F660 Offset: 0x1E2F761 VA: 0x1E2F660
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFBB0 Offset: 0x1AFCB1 VA: 0x1AFBB0
	// RVA: 0x1E2FC80 Offset: 0x1E2FD81 VA: 0x1E2FC80
	private IEnumerator CheckGateTreasureBox() { }

	// RVA: 0x1E2FD30 Offset: 0x1E2FE31 VA: 0x1E2FD30
	private bool ExistGateControllerUniqueBox(GateDataID gateDataID) { }

	// RVA: 0x1E2FE50 Offset: 0x1E2FF51 VA: 0x1E2FE50
	public void RemoveRandomTreasureBox() { }

	// RVA: 0x1E29200 Offset: 0x1E29301 VA: 0x1E29200
	public GameObject InstantiateTreasureBoxPrefab(FieldTreasureBoxType type, Transform parent) { }

	// RVA: 0x1E28370 Offset: 0x1E28471 VA: 0x1E28370
	public void SpawnMonsterBox(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFC20 Offset: 0x1AFD21 VA: 0x1AFC20
	// RVA: 0x1E302A0 Offset: 0x1E303A1 VA: 0x1E302A0
	public IEnumerator SpawnMonsterBoxCoroutine(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E29360 Offset: 0x1E29461 VA: 0x1E29360
	public bool CheckMonsterSpawn(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E30370 Offset: 0x1E30471 VA: 0x1E30370
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29690 Offset: 0x1E29791 VA: 0x1E29690
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30450 Offset: 0x1E30551 VA: 0x1E30450
	public bool AddTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30530 Offset: 0x1E30631 VA: 0x1E30530
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2C110 Offset: 0x1E2C211 VA: 0x1E2C110
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldTreasureBoxDataType boxDataType, int boxSpawnID) { }

	// RVA: 0x1E30610 Offset: 0x1E30711 VA: 0x1E30610
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28240 Offset: 0x1E28341 VA: 0x1E28240
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E306B0 Offset: 0x1E307B1 VA: 0x1E306B0
	public bool RemoveTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2A920 Offset: 0x1E2AA21 VA: 0x1E2A920
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30750 Offset: 0x1E30851 VA: 0x1E30750
	public bool FieldUniqueTreasureBoxSpawnIDExists(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28D50 Offset: 0x1E28E51 VA: 0x1E28D50
	public bool FieldRandomTreasureBoxSpawnIDExists(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E307D0 Offset: 0x1E308D1 VA: 0x1E307D0
	public bool FieldWoodBoxSpawnIDExists(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B030 Offset: 0x1E2B131 VA: 0x1E2B030
	public bool FieldRewardTreasureBoxSpawnIDExists(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30850 Offset: 0x1E30951 VA: 0x1E30850
	public FieldTreasureBox GetTreasureBox(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28DD0 Offset: 0x1E28ED1 VA: 0x1E28DD0
	public FieldTreasureBox GetTreasureBox(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2FBE0 Offset: 0x1E2FCE1 VA: 0x1E2FBE0
	public GameObject GetTreasureBox(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B0B0 Offset: 0x1E2B1B1 VA: 0x1E2B0B0
	public FieldTreasureBox GetTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B8D0 Offset: 0x1E2B9D1 VA: 0x1E2B8D0
	public void AddUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E308F0 Offset: 0x1E309F1 VA: 0x1E308F0
	public void RemoveUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28530 Offset: 0x1E28631 VA: 0x1E28530
	public void AddRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28160 Offset: 0x1E28261 VA: 0x1E28160
	public void RemoveRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E285A0 Offset: 0x1E286A1 VA: 0x1E285A0
	public void AddBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E281D0 Offset: 0x1E282D1 VA: 0x1E281D0
	public void RemoveBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2AA90 Offset: 0x1E2AB91 VA: 0x1E2AA90
	public void AddRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2A8B0 Offset: 0x1E2A9B1 VA: 0x1E2A8B0
	public void RemoveRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2C4A0 Offset: 0x1E2C5A1 VA: 0x1E2C4A0
	public static void SetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28C70 Offset: 0x1E28D71 VA: 0x1E28C70
	public static bool GetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool checkItemFlag = False) { }

	// RVA: 0x1E2C9C0 Offset: 0x1E2CAC1 VA: 0x1E2C9C0
	public static void SetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28E70 Offset: 0x1E28F71 VA: 0x1E28E70
	public static bool GetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id) { }

	// RVA: 0x1E2FB00 Offset: 0x1E2FC01 VA: 0x1E2FB00
	public static void SetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id, bool value) { }

	// RVA: 0x1E30960 Offset: 0x1E30A61 VA: 0x1E30960
	public static bool GetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id) { }

	// RVA: 0x1E28C00 Offset: 0x1E28D01 VA: 0x1E28C00
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E30A50 Offset: 0x1E30B51 VA: 0x1E30A50
	public void OnChangeHideDetectFlag() { }

	// RVA: 0x1E30C60 Offset: 0x1E30D61 VA: 0x1E30C60
	public void OnChangeHideDetectFlag(bool visible) { }

	// RVA: 0x1E30D80 Offset: 0x1E30E81 VA: 0x1E30D80
	public void SetTargetItemName(ItemDataTable targetItemDataTable) { }

	// RVA: 0x1E30D90 Offset: 0x1E30E91 VA: 0x1E30D90
	public string GetTargetItemName() { }

	// RVA: 0x1E30DB0 Offset: 0x1E30EB1 VA: 0x1E30DB0
	public void SetTargetMoney(int value) { }

	// RVA: 0x1E30DC0 Offset: 0x1E30EC1 VA: 0x1E30DC0
	public string GetTargetMoney() { }

	// RVA: 0x1E30DD0 Offset: 0x1E30ED1 VA: 0x1E30DD0
	public void SpawnOrderRewardTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID = 1) { }

	// RVA: 0x1E30F40 Offset: 0x1E31041 VA: 0x1E30F40
	public void SpawnWantedRewardTreasureBox() { }

	// RVA: 0x1E310B0 Offset: 0x1E311B1 VA: 0x1E310B0
	public void SpawnFestivalRewardTreasureBox() { }

	// RVA: 0x1E2AE80 Offset: 0x1E2AF81 VA: 0x1E2AE80
	public static int GetRewardCount(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E2CAA0 Offset: 0x1E2CBA1 VA: 0x1E2CAA0
	public static FieldRewardTreasureBoxData GetRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E31220 Offset: 0x1E31321 VA: 0x1E31220
	public static FieldRewardTreasureBoxData GetOrderRewardData() { }

	// RVA: 0x1E31450 Offset: 0x1E31551 VA: 0x1E31450
	public static FieldRewardTreasureBoxData GetWantedRewardData() { }

	// RVA: 0x1E31570 Offset: 0x1E31671 VA: 0x1E31570
	public static FieldRewardTreasureBoxData GetFestivalRewardData() { }

	// RVA: 0x1E31690 Offset: 0x1E31791 VA: 0x1E31690
	public static void AddOrderReward(int type, int id, int amount, int level, int npcId) { }

	// RVA: 0x1E31760 Offset: 0x1E31861 VA: 0x1E31760
	public static void AddWantedReward(int id, int amount, int level) { }

	// RVA: 0x1E2CC20 Offset: 0x1E2CD21 VA: 0x1E2CC20
	public static void ClearRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E317C0 Offset: 0x1E318C1 VA: 0x1E317C0
	public void RemoveFestivalRewardTreasureBox() { }

	// RVA: 0x1E31930 Offset: 0x1E31A31 VA: 0x1E31930
	public void .ctor() { }
}

public class FieldTreasureBoxManager : SingletonMonoBehaviour<FieldTreasureBoxManager> // TypeDefIndex: 10514
{
	// Fields
	private const int GateWaitCount = 10;
	private const int DispDistanceSqr = 4096;
	private GameObject[] TreasureBoxPrefabs; // 0x18
	private Dictionary<FieldUniqueTreasureBoxSpawnID, FieldTreasureBox> UniqueBoxObjectDictonary; // 0x20
	private Dictionary<FieldRandomTreasureBoxSpawnID, FieldTreasureBox> RandomBoxObjectDictonary; // 0x28
	private Dictionary<FieldWoodBoxSpawnID, GameObject> WoodBoxObjectDictonary; // 0x30
	private Dictionary<FieldRewardTreasureBoxSpawnID, FieldTreasureBox> RewardBoxObjectDictonary; // 0x38
	private FieldUniqueTreasureBoxSpawnDataTableArray _FieldUniqueBoxSpawnDataTableArray; // 0x40
	private FieldRandomTreasureBoxSpawnDataTableArray _FieldRandomBoxSpawnDataTableArray; // 0x48
	private FieldWoodBoxSpawnDataTableArray _FieldWoodBoxSpawnDataTableArray; // 0x50
	private HashSet<FieldUniqueTreasureBoxSpawnID> _ExistUniqueSpawnIDHashSet; // 0x58
	private HashSet<FieldRandomTreasureBoxSpawnID> _ExistRandomSpawnIDHashSet; // 0x60
	private HashSet<FieldWoodBoxSpawnID> _ExistWoodSpawnIDHashSet; // 0x68
	private HashSet<FieldRewardTreasureBoxSpawnID> _ExistRewardSpawnIDHashSet; // 0x70
	private HashSet<FieldUniqueTreasureBoxSpawner> ExistUniqueSpawnerHashSet; // 0x78
	private HashSet<FieldRandomTreasureBoxSpawner> ExistRandomSpawnerHashSet; // 0x80
	private HashSet<FieldRewardTreasureBoxSpawner> ExistRewardSpawnerHashSet; // 0x88
	private HashSet<FieldRandomTreasureBoxSpawner> ExistBossStageRandomSpawnerHashSet; // 0x90
	private ItemDataTable targetItemData; // 0x98
	private int targetMoney; // 0xA0
	public Transform OrderRewardRootTransform; // 0xA8
	private GameObject OrderRewardTreasureBox; // 0xB0

	// Properties
	public bool IsShowHideTreasureBox { get; }
	public HashSet<FieldUniqueTreasureBoxSpawnID> ExistUniqueSpawnIDHashSet { get; set; }
	public HashSet<FieldRandomTreasureBoxSpawnID> ExistRandomSpawnIDHashSet { get; set; }
	public HashSet<FieldWoodBoxSpawnID> ExistWoodSpawnIDHashSet { get; set; }
	public HashSet<FieldRewardTreasureBoxSpawnID> ExistRewardSpawnIDHashSet { get; set; }

	// Methods

	// RVA: 0x1E2E350 Offset: 0x1E2E451 VA: 0x1E2E350
	public bool get_IsShowHideTreasureBox() { }

	// RVA: 0x1E2E3C0 Offset: 0x1E2E4C1 VA: 0x1E2E3C0
	public HashSet<FieldUniqueTreasureBoxSpawnID> get_ExistUniqueSpawnIDHashSet() { }

	// RVA: 0x1E2E3D0 Offset: 0x1E2E4D1 VA: 0x1E2E3D0
	private void set_ExistUniqueSpawnIDHashSet(HashSet<FieldUniqueTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E3E0 Offset: 0x1E2E4E1 VA: 0x1E2E3E0
	public HashSet<FieldRandomTreasureBoxSpawnID> get_ExistRandomSpawnIDHashSet() { }

	// RVA: 0x1E2E3F0 Offset: 0x1E2E4F1 VA: 0x1E2E3F0
	private void set_ExistRandomSpawnIDHashSet(HashSet<FieldRandomTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E400 Offset: 0x1E2E501 VA: 0x1E2E400
	public HashSet<FieldWoodBoxSpawnID> get_ExistWoodSpawnIDHashSet() { }

	// RVA: 0x1E2E410 Offset: 0x1E2E511 VA: 0x1E2E410
	private void set_ExistWoodSpawnIDHashSet(HashSet<FieldWoodBoxSpawnID> value) { }

	// RVA: 0x1E2E420 Offset: 0x1E2E521 VA: 0x1E2E420
	public HashSet<FieldRewardTreasureBoxSpawnID> get_ExistRewardSpawnIDHashSet() { }

	// RVA: 0x1E2E430 Offset: 0x1E2E531 VA: 0x1E2E430
	private void set_ExistRewardSpawnIDHashSet(HashSet<FieldRewardTreasureBoxSpawnID> value) { }

	// RVA: 0x1E2E440 Offset: 0x1E2E541 VA: 0x1E2E440
	public static FieldUniqueTreasureBoxSpawnDataTable[] GetUniqueBoxDataTables() { }

	// RVA: 0x1E2E4A0 Offset: 0x1E2E5A1 VA: 0x1E2E4A0
	public static FieldRandomTreasureBoxSpawnDataTable[] GetRandomBoxDataTables() { }

	// RVA: 0x1E2E500 Offset: 0x1E2E601 VA: 0x1E2E500
	public static FieldWoodBoxSpawnDataTable[] GetWoodBoxDataTables() { }

	// RVA: 0x1E2E560 Offset: 0x1E2E661 VA: 0x1E2E560
	public static FieldUniqueTreasureBoxSpawnDataTable GetUniqueBoxDataTable(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E610 Offset: 0x1E2E711 VA: 0x1E2E610
	public static FieldRandomTreasureBoxSpawnDataTable GetRandomBoxDataTable(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E6C0 Offset: 0x1E2E7C1 VA: 0x1E2E6C0
	public static FieldWoodBoxSpawnDataTable GetWoodBoxDataTable(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E770 Offset: 0x1E2E871 VA: 0x1E2E770
	public static FieldUniqueTreasureBoxData GetBoxData(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29010 Offset: 0x1E29111 VA: 0x1E29010
	public static FieldRandomTreasureBoxData GetBoxData(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2E8F0 Offset: 0x1E2E9F1 VA: 0x1E2E8F0
	public static FieldWoodBoxData GetBoxData(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B150 Offset: 0x1E2B251 VA: 0x1E2B150
	public static FieldRewardTreasureBoxData GetBoxData(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2EA10 Offset: 0x1E2EB11 VA: 0x1E2EA10
	public void InitializeLoad() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFAD0 Offset: 0x1AFBD1 VA: 0x1AFAD0
	// RVA: 0x1E2EB00 Offset: 0x1E2EC01 VA: 0x1E2EB00
	public IEnumerator LoadDataTable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFB40 Offset: 0x1AFC41 VA: 0x1AFB40
	// RVA: 0x1E2EB80 Offset: 0x1E2EC81 VA: 0x1E2EB80
	public IEnumerator LoadModelDataAsync() { }

	// RVA: 0x1E2EC60 Offset: 0x1E2ED61 VA: 0x1E2EC60
	private void OnDestroy() { }

	// RVA: 0x1E2EDE0 Offset: 0x1E2EEE1 VA: 0x1E2EDE0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E2EE30 Offset: 0x1E2EF31 VA: 0x1E2EE30
	private void Start() { }

	// RVA: 0x1E2EE40 Offset: 0x1E2EF41 VA: 0x1E2EE40
	private void Update() { }

	// RVA: 0x1E2EE50 Offset: 0x1E2EF51 VA: 0x1E2EE50
	private void UpdateMimickMonster() { }

	// RVA: 0x1E2F2A0 Offset: 0x1E2F3A1 VA: 0x1E2F2A0
	private static bool Lottery(int weight) { }

	// RVA: 0x1E2F2E0 Offset: 0x1E2F3E1 VA: 0x1E2F2E0
	public void OnAfterGameDataLoad() { }

	// RVA: 0x1E2F400 Offset: 0x1E2F501 VA: 0x1E2F400
	public static void OnDayChangeSetFieldFlag(int elapsedDay = 1) { }

	// RVA: 0x1E2F660 Offset: 0x1E2F761 VA: 0x1E2F660
	public void OnSceneChangeSetFieldFlag() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFBB0 Offset: 0x1AFCB1 VA: 0x1AFBB0
	// RVA: 0x1E2FC80 Offset: 0x1E2FD81 VA: 0x1E2FC80
	private IEnumerator CheckGateTreasureBox() { }

	// RVA: 0x1E2FD30 Offset: 0x1E2FE31 VA: 0x1E2FD30
	private bool ExistGateControllerUniqueBox(GateDataID gateDataID) { }

	// RVA: 0x1E2FE50 Offset: 0x1E2FF51 VA: 0x1E2FE50
	public void RemoveRandomTreasureBox() { }

	// RVA: 0x1E29200 Offset: 0x1E29301 VA: 0x1E29200
	public GameObject InstantiateTreasureBoxPrefab(FieldTreasureBoxType type, Transform parent) { }

	// RVA: 0x1E28370 Offset: 0x1E28471 VA: 0x1E28370
	public void SpawnMonsterBox(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AFC20 Offset: 0x1AFD21 VA: 0x1AFC20
	// RVA: 0x1E302A0 Offset: 0x1E303A1 VA: 0x1E302A0
	public IEnumerator SpawnMonsterBoxCoroutine(MonsterDataID monsterDataID, FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E29360 Offset: 0x1E29461 VA: 0x1E29360
	public bool CheckMonsterSpawn(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E30370 Offset: 0x1E30471 VA: 0x1E30370
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E29690 Offset: 0x1E29791 VA: 0x1E29690
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30450 Offset: 0x1E30551 VA: 0x1E30450
	public bool AddTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30530 Offset: 0x1E30631 VA: 0x1E30530
	public bool AddTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2C110 Offset: 0x1E2C211 VA: 0x1E2C110
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldTreasureBoxDataType boxDataType, int boxSpawnID) { }

	// RVA: 0x1E30610 Offset: 0x1E30711 VA: 0x1E30610
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28240 Offset: 0x1E28341 VA: 0x1E28240
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E306B0 Offset: 0x1E307B1 VA: 0x1E306B0
	public bool RemoveTreasureBox(GameObject treasureBox, FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2A920 Offset: 0x1E2AA21 VA: 0x1E2A920
	public bool RemoveTreasureBox(FieldTreasureBox treasureBox, FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30750 Offset: 0x1E30851 VA: 0x1E30750
	public bool FieldUniqueTreasureBoxSpawnIDExists(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28D50 Offset: 0x1E28E51 VA: 0x1E28D50
	public bool FieldRandomTreasureBoxSpawnIDExists(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E307D0 Offset: 0x1E308D1 VA: 0x1E307D0
	public bool FieldWoodBoxSpawnIDExists(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B030 Offset: 0x1E2B131 VA: 0x1E2B030
	public bool FieldRewardTreasureBoxSpawnIDExists(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E30850 Offset: 0x1E30951 VA: 0x1E30850
	public FieldTreasureBox GetTreasureBox(FieldUniqueTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E28DD0 Offset: 0x1E28ED1 VA: 0x1E28DD0
	public FieldTreasureBox GetTreasureBox(FieldRandomTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2FBE0 Offset: 0x1E2FCE1 VA: 0x1E2FBE0
	public GameObject GetTreasureBox(FieldWoodBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B0B0 Offset: 0x1E2B1B1 VA: 0x1E2B0B0
	public FieldTreasureBox GetTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID) { }

	// RVA: 0x1E2B8D0 Offset: 0x1E2B9D1 VA: 0x1E2B8D0
	public void AddUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E308F0 Offset: 0x1E309F1 VA: 0x1E308F0
	public void RemoveUniqueSpawner(FieldUniqueTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28530 Offset: 0x1E28631 VA: 0x1E28530
	public void AddRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E28160 Offset: 0x1E28261 VA: 0x1E28160
	public void RemoveRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E285A0 Offset: 0x1E286A1 VA: 0x1E285A0
	public void AddBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E281D0 Offset: 0x1E282D1 VA: 0x1E281D0
	public void RemoveBossStageRandomSpawner(FieldRandomTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2AA90 Offset: 0x1E2AB91 VA: 0x1E2AA90
	public void AddRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2A8B0 Offset: 0x1E2A9B1 VA: 0x1E2A8B0
	public void RemoveRewardSpawner(FieldRewardTreasureBoxSpawner treasureBoxSpawner) { }

	// RVA: 0x1E2C4A0 Offset: 0x1E2C5A1 VA: 0x1E2C4A0
	public static void SetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28C70 Offset: 0x1E28D71 VA: 0x1E28C70
	public static bool GetFieldUniqueBoxSpawnFlag(FieldUniqueTreasureBoxSpawnID id, bool checkItemFlag = False) { }

	// RVA: 0x1E2C9C0 Offset: 0x1E2CAC1 VA: 0x1E2C9C0
	public static void SetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id, bool value) { }

	// RVA: 0x1E28E70 Offset: 0x1E28F71 VA: 0x1E28E70
	public static bool GetFieldRandomBoxSpawnFlag(FieldRandomTreasureBoxSpawnID id) { }

	// RVA: 0x1E2FB00 Offset: 0x1E2FC01 VA: 0x1E2FB00
	public static void SetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id, bool value) { }

	// RVA: 0x1E30960 Offset: 0x1E30A61 VA: 0x1E30960
	public static bool GetFieldWoodBoxSpawnFlag(FieldWoodBoxSpawnID id) { }

	// RVA: 0x1E28C00 Offset: 0x1E28D01 VA: 0x1E28C00
	public static bool IsRestrictSpawn() { }

	// RVA: 0x1E30A50 Offset: 0x1E30B51 VA: 0x1E30A50
	public void OnChangeHideDetectFlag() { }

	// RVA: 0x1E30C60 Offset: 0x1E30D61 VA: 0x1E30C60
	public void OnChangeHideDetectFlag(bool visible) { }

	// RVA: 0x1E30D80 Offset: 0x1E30E81 VA: 0x1E30D80
	public void SetTargetItemName(ItemDataTable targetItemDataTable) { }

	// RVA: 0x1E30D90 Offset: 0x1E30E91 VA: 0x1E30D90
	public string GetTargetItemName() { }

	// RVA: 0x1E30DB0 Offset: 0x1E30EB1 VA: 0x1E30DB0
	public void SetTargetMoney(int value) { }

	// RVA: 0x1E30DC0 Offset: 0x1E30EC1 VA: 0x1E30DC0
	public string GetTargetMoney() { }

	// RVA: 0x1E30DD0 Offset: 0x1E30ED1 VA: 0x1E30DD0
	public void SpawnOrderRewardTreasureBox(FieldRewardTreasureBoxSpawnID boxSpawnID = 1) { }

	// RVA: 0x1E30F40 Offset: 0x1E31041 VA: 0x1E30F40
	public void SpawnWantedRewardTreasureBox() { }

	// RVA: 0x1E310B0 Offset: 0x1E311B1 VA: 0x1E310B0
	public void SpawnFestivalRewardTreasureBox() { }

	// RVA: 0x1E2AE80 Offset: 0x1E2AF81 VA: 0x1E2AE80
	public static int GetRewardCount(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E2CAA0 Offset: 0x1E2CBA1 VA: 0x1E2CAA0
	public static FieldRewardTreasureBoxData GetRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E31220 Offset: 0x1E31321 VA: 0x1E31220
	public static FieldRewardTreasureBoxData GetOrderRewardData() { }

	// RVA: 0x1E31450 Offset: 0x1E31551 VA: 0x1E31450
	public static FieldRewardTreasureBoxData GetWantedRewardData() { }

	// RVA: 0x1E31570 Offset: 0x1E31671 VA: 0x1E31570
	public static FieldRewardTreasureBoxData GetFestivalRewardData() { }

	// RVA: 0x1E31690 Offset: 0x1E31791 VA: 0x1E31690
	public static void AddOrderReward(int type, int id, int amount, int level, int npcId) { }

	// RVA: 0x1E31760 Offset: 0x1E31861 VA: 0x1E31760
	public static void AddWantedReward(int id, int amount, int level) { }

	// RVA: 0x1E2CC20 Offset: 0x1E2CD21 VA: 0x1E2CC20
	public static void ClearRewardData(FieldRewardTreasureBoxSpawnID spawnId) { }

	// RVA: 0x1E317C0 Offset: 0x1E318C1 VA: 0x1E317C0
	public void RemoveFestivalRewardTreasureBox() { }

	// RVA: 0x1E31930 Offset: 0x1E31A31 VA: 0x1E31930
	public void .ctor() { }
}


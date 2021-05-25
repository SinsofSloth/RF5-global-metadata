public class MiningManager : SingletonMonoBehaviour<MiningManager> // TypeDefIndex: 7446
{
	// Fields
	private HashSet<int> _miningPointUniqueIdSet; // 0x18
	private int _miningPointMinimumUniqueId; // 0x20
	private List<MiningPointSaveData> _miningPointSaveDatas; // 0x28
	private List<MiningPoint> _farmMiningPoints; // 0x30
	private GameObject _farmMineBasePrefab; // 0x38
	public Dictionary<int, MineTypeID> FieldMiningAppearList; // 0x40
	public HashSet<MiningPoint> SceneMiningPointHashSet; // 0x48
	private Weather latestWeather; // 0x50

	// Properties
	public List<int> MeteorList { get; }

	// Methods

	// RVA: 0x1CB1860 Offset: 0x1CB1961 VA: 0x1CB1860
	public List<int> get_MeteorList() { }

	// RVA: 0x1CB1890 Offset: 0x1CB1991 VA: 0x1CB1890
	private void OnDestroy() { }

	// RVA: 0x1CB1960 Offset: 0x1CB1A61 VA: 0x1CB1960
	public void AddMiningPoint(MiningPointSaveData miningPointSaveData) { }

	// RVA: 0x1CB1C80 Offset: 0x1CB1D81 VA: 0x1CB1C80
	public void AddFarmMiningPoint(MiningPoint miningPoint) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0ED0 Offset: 0x1A0FD1 VA: 0x1A0ED0
	// RVA: 0x1CB1E40 Offset: 0x1CB1F41 VA: 0x1CB1E40
	public IEnumerator CreateMiningPointObject(MiningPoint miningPoint, string prefabName = "", UnityAction<GameObject> callback) { }

	// RVA: 0x1CB1F20 Offset: 0x1CB2021 VA: 0x1CB1F20
	public List<MiningPointSaveData> GetMiningPoints(FarmManager.FARM_ID farmId) { }

	// RVA: 0x1CB1A40 Offset: 0x1CB1B41 VA: 0x1CB1A40
	private int getMiningPointSaveDataTempIndex() { }

	// RVA: 0x1CB2010 Offset: 0x1CB2111 VA: 0x1CB2010
	public void RemoveMiningPoint(MiningPoint miningPoint) { }

	// RVA: 0x1CB2630 Offset: 0x1CB2731 VA: 0x1CB2630
	public void RemoveMiningPoint(MiningPointSaveData miningPointSaveData) { }

	// RVA: 0x1CB2270 Offset: 0x1CB2371 VA: 0x1CB2270
	private void tutorialWorking() { }

	// RVA: 0x1CB2B90 Offset: 0x1CB2C91 VA: 0x1CB2B90
	public bool IsGomiZero() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0F40 Offset: 0x1A1041 VA: 0x1A0F40
	// RVA: 0x1CB2CB0 Offset: 0x1CB2DB1 VA: 0x1CB2CB0
	public IEnumerator LoadMiningPoint() { }

	// RVA: 0x1CB2D60 Offset: 0x1CB2E61 VA: 0x1CB2D60
	public void LoadMiningPointSaveData() { }

	// RVA: 0x1CB2F50 Offset: 0x1CB3051 VA: 0x1CB2F50
	private void checkMiningPoint2Hour(int elapsedDay) { }

	// RVA: 0x1CB3010 Offset: 0x1CB3111 VA: 0x1CB3010
	private void checkMiningPoint2Day(int elapsedDay) { }

	// RVA: 0x1CB3130 Offset: 0x1CB3231 VA: 0x1CB3130
	private void lotteryMiningPoints() { }

	// RVA: 0x1CB3220 Offset: 0x1CB3321 VA: 0x1CB3220
	private void clearMeteorMiningPoints() { }

	// RVA: 0x1CB32D0 Offset: 0x1CB33D1 VA: 0x1CB32D0
	public MiningPoint GetMiningPoint(MiningPointSaveData data) { }

	// RVA: 0x1CB33F0 Offset: 0x1CB34F1 VA: 0x1CB33F0
	public List<MiningPoint> GetWorkAreaMiningPoints(int area) { }

	// RVA: 0x1CB3620 Offset: 0x1CB3721 VA: 0x1CB3620
	public List<MiningPointSaveData> GetWorkAreaMiningPointSaveDatas(FarmManager.FARM_ID farmID, int area) { }

	// RVA: 0x1CB3830 Offset: 0x1CB3931 VA: 0x1CB3830
	public bool CheckMiningPointAvailable(MiningPointSaveData miningPointSaveData) { }

	// RVA: 0x1CB38A0 Offset: 0x1CB39A1 VA: 0x1CB38A0
	public MiningManager.MINING_MONSTER_TASK CanMiningAction(MiningPointSaveData miningPointSaveData) { }

	// RVA: 0x1CB38D0 Offset: 0x1CB39D1 VA: 0x1CB38D0
	public bool DoMiningAction(MiningPointSaveData miningPointSaveData, Vector3 rotation) { }

	// RVA: 0x1CB3DA0 Offset: 0x1CB3EA1 VA: 0x1CB3DA0
	public void DestroyOnGroundItem(MiningPointSaveData miningPointSaveData) { }

	// RVA: 0x1CB1B60 Offset: 0x1CB1C61 VA: 0x1CB1B60
	public static int GetUniqueId() { }

	// RVA: 0x1CB2980 Offset: 0x1CB2A81 VA: 0x1CB2980
	public static int PickupUniqueId(FarmManager.FARM_ID farmID, Vector3 position) { }

	// RVA: 0x1CB4240 Offset: 0x1CB4341 VA: 0x1CB4240
	public void EntrySceneMiningPoint(MiningPoint miningPoint) { }

	// RVA: 0x1CB42B0 Offset: 0x1CB43B1 VA: 0x1CB42B0
	public void RemoveSceneMiningPoint(MiningPoint miningPoint) { }

	// RVA: 0x1CB4320 Offset: 0x1CB4421 VA: 0x1CB4320
	public void OnEndTeleport() { }

	// RVA: 0x1CB4590 Offset: 0x1CB4691 VA: 0x1CB4590
	public void BeforeSave() { }

	// RVA: 0x1CB4610 Offset: 0x1CB4711 VA: 0x1CB4610
	private void Start() { }

	// RVA: 0x1CB47C0 Offset: 0x1CB48C1 VA: 0x1CB47C0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0FB0 Offset: 0x1A10B1 VA: 0x1A0FB0
	// RVA: 0x1CB4920 Offset: 0x1CB4A21 VA: 0x1CB4920
	private void <LoadMiningPoint>b__20_0(AssetHandle<GameObject> handle) { }
}


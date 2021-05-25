public class FarmSupportMonsterManager : SingletonMonoBehaviour<FarmSupportMonsterManager> // TypeDefIndex: 8047
{
	// Fields
	public static readonly Dictionary<int, FarmSupportMonsterManager.FarmScene> FarmIDToFarmScene; // 0x0
	public static readonly Vector3 HutRoomDoor; // 0x8
	public static readonly Dictionary<int, Vector3> HutRoomPosition; // 0x18
	public static readonly Dictionary<int, List<Vector3>> DragonFarmHutDoorDic; // 0x20
	public static readonly float WorkTimeStart; // 0x28
	public static readonly float WorkTimeStart_Seed; // 0x2C
	public static readonly float WorkTimeStart_Water; // 0x30
	public static readonly float WorkTimeStart_Crop; // 0x34
	public static readonly float WorkTimeEnd; // 0x38
	public static readonly Dictionary<int, int> AreaIDToAreaNo; // 0x40
	private const float MoneyBias = 0.005;
	private List<FarmSupportMonsterController> FarmSupportMonsterControllerList; // 0x18
	public FieldSceneId PlayerFieldSceneId; // 0x20
	private List<FarmSupportMonsterManager.OrderFarmInParameter> FarmInOrderList; // 0x28
	private FarmSupportMonsterManager.OrderFarmInParameter CurrentOrderFarmInParameter; // 0x30
	private bool IsCreating; // 0x38
	private SeedShopItemDataTable SeedShopItemDataTable; // 0x40
	private List<SeedShopItemDataTable.SeedShopItemData> CanBuySeedList; // 0x48
	private List<FarmSupportMonsterController> CurrentRemoveControllerList; // 0x50

	// Methods

	// RVA: 0x2033D80 Offset: 0x2033E81 VA: 0x2033D80
	public List<FarmFieldWorkArea> GetFreeFarmFieldWorkAreas(FarmManager.FARM_ID farmID) { }

	// RVA: 0x2033F00 Offset: 0x2034001 VA: 0x2033F00
	public FarmFieldWorkArea GetFreeFarmFieldWorkArea(FarmManager.FARM_ID farmID) { }

	// RVA: 0x2033FC0 Offset: 0x20340C1 VA: 0x2033FC0
	public bool IsExistFarmSupportMonster(FarmManager.FARM_ID farmID, FarmFieldWorkArea farmFieldWorkArea) { }

	// RVA: 0x20340B0 Offset: 0x20341B1 VA: 0x20340B0
	public static void InitializeForNewGame() { }

	// RVA: 0x20340C0 Offset: 0x20341C1 VA: 0x20340C0
	public void OnAfterGameDataLoad() { }

	// RVA: 0x20342D0 Offset: 0x20343D1 VA: 0x20342D0
	public void AddFarmSupportMonster(uint friendMonsterDataID) { }

	// RVA: 0x20344F0 Offset: 0x20345F1 VA: 0x20344F0
	private void UpdateData() { }

	// RVA: 0x2034650 Offset: 0x2034751 VA: 0x2034650
	private void UpdateFrame() { }

	// RVA: 0x2034710 Offset: 0x2034811 VA: 0x2034710
	public void UpdateDay(int elapsedTime) { }

	// RVA: 0x2034800 Offset: 0x2034901 VA: 0x2034800
	public void OnBeginTeleport() { }

	// RVA: 0x2034860 Offset: 0x2034961 VA: 0x2034860
	public void OnEndTeleport() { }

	// RVA: 0x2033710 Offset: 0x2033811 VA: 0x2033710
	public void OrderFarmIn(uint friendMonsterDataID, Action<uint, ActorID> callBack) { }

	// RVA: 0x20348E0 Offset: 0x20349E1 VA: 0x20348E0
	public void UpdateOrderFarmInList() { }

	// RVA: 0x2034260 Offset: 0x2034361 VA: 0x2034260
	public void UpdateCanBuySeedItemDataList() { }

	// RVA: 0x20315F0 Offset: 0x20316F1 VA: 0x20315F0
	public ItemData GetPlantSeed() { }

	// RVA: 0x20349E0 Offset: 0x2034AE1 VA: 0x20349E0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2034B70 Offset: 0x2034C71 VA: 0x2034B70
	private void Update() { }

	// RVA: 0x2034BA0 Offset: 0x2034CA1 VA: 0x2034BA0
	public void .ctor() { }

	// RVA: 0x2034CC0 Offset: 0x2034DC1 VA: 0x2034CC0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A56A0 Offset: 0x1A57A1 VA: 0x1A56A0
	// RVA: 0x2035730 Offset: 0x2035831 VA: 0x2035730
	private void <UpdateOrderFarmInList>b__33_0(uint u, ActorID id) { }
}


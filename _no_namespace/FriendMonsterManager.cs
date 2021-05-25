public class FriendMonsterManager : MonoBehaviour // TypeDefIndex: 6310
{
	// Fields
	private Dictionary<uint, FriendMonsterStatus> StatusList; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15C0B0 Offset: 0x15C1B1 VA: 0x15C0B0
	private static FriendMonsterManager <Instance>k__BackingField; // 0x0
	private List<FriendMonsterManager.FarmInActorData> FarmInActorList; // 0x20
	private Action<uint, ActorID> FarmInCallback; // 0x28
	private bool IsBusy; // 0x30

	// Properties
	private List<FriendMonsterStatusData> StatusDataList { get; }
	public static List<FriendMonsterStatusData> FriendMonsterStatusDatas { get; }
	public static Dictionary<uint, FriendMonsterStatus> FriendMonsters { get; }
	public static FriendMonsterManager Instance { get; set; }

	// Methods

	// RVA: 0x1D62160 Offset: 0x1D62261 VA: 0x1D62160
	private List<FriendMonsterStatusData> get_StatusDataList() { }

	// RVA: 0x1D62190 Offset: 0x1D62291 VA: 0x1D62190
	public static List<FriendMonsterStatusData> get_FriendMonsterStatusDatas() { }

	// RVA: 0x1D62200 Offset: 0x1D62301 VA: 0x1D62200
	public static Dictionary<uint, FriendMonsterStatus> get_FriendMonsters() { }

	// RVA: 0x1D62260 Offset: 0x1D62361 VA: 0x1D62260
	public static void InitializeForLoadGame() { }

	// RVA: 0x1D624F0 Offset: 0x1D625F1 VA: 0x1D624F0
	public static int EmptyCount() { }

	// RVA: 0x1D61DE0 Offset: 0x1D61EE1 VA: 0x1D61DE0
	public static int SameMonsterCount(MonsterID monsterID) { }

	// RVA: 0x1D62550 Offset: 0x1D62651 VA: 0x1D62550
	public static uint JoinIn(string name, EnemyStatusData mosterStatusData) { }

	// RVA: 0x1D62720 Offset: 0x1D62821 VA: 0x1D62720
	public static void Leave(uint id) { }

	// RVA: 0x1D628F0 Offset: 0x1D629F1 VA: 0x1D628F0
	public static void FarmIn(FarmManager.FARM_ID farmId, int houseId, Action<uint, ActorID> callback) { }

	// RVA: 0x1D62D40 Offset: 0x1D62E41 VA: 0x1D62D40
	public static void FarmOut() { }

	// RVA: 0x1D62FC0 Offset: 0x1D630C1 VA: 0x1D62FC0
	public static void FarmIn(uint dataId, Action<uint, ActorID> callback) { }

	// RVA: 0x1D63410 Offset: 0x1D63511 VA: 0x1D63410
	public static void FarmOut(uint dataId, bool isPlayEffect = False) { }

	// RVA: 0x1D63740 Offset: 0x1D63841 VA: 0x1D63740
	public static int OneDayEsaCost() { }

	// RVA: 0x1D63970 Offset: 0x1D63A71 VA: 0x1D63970
	public void Morning() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ABD0 Offset: 0x19ACD1 VA: 0x19ABD0
	// RVA: 0x1D64300 Offset: 0x1D64401 VA: 0x1D64300
	public static FriendMonsterManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19ABE0 Offset: 0x19ACE1 VA: 0x19ABE0
	// RVA: 0x1D64350 Offset: 0x1D64451 VA: 0x1D64350
	private static void set_Instance(FriendMonsterManager value) { }

	// RVA: 0x1D643B0 Offset: 0x1D644B1 VA: 0x1D643B0
	private void Awake() { }

	// RVA: 0x1D622C0 Offset: 0x1D623C1 VA: 0x1D622C0
	public void LoadInit() { }

	// RVA: 0x1D64420 Offset: 0x1D64521 VA: 0x1D64420
	private uint GetNextId() { }

	// RVA: 0x1D625D0 Offset: 0x1D626D1 VA: 0x1D625D0
	private uint Create(string name, EnemyStatusData mosterStatusData) { }

	// RVA: 0x1D62790 Offset: 0x1D62891 VA: 0x1D62790
	private void Release(uint dataId) { }

	// RVA: 0x1D644D0 Offset: 0x1D645D1 VA: 0x1D644D0
	private void CreateMonster(uint dataId, ActorID actorId) { }

	// RVA: 0x1D63040 Offset: 0x1D63141 VA: 0x1D63040
	private bool FarmInCreate(uint dataId, Action<uint, ActorID> callback) { }

	// RVA: 0x1D62970 Offset: 0x1D62A71 VA: 0x1D62970
	private void FarmInCreate(FarmManager.FARM_ID farmId, int houseId, Action<uint, ActorID> callback) { }

	// RVA: 0x1D63490 Offset: 0x1D63591 VA: 0x1D63490
	private void FarmOutDelete(uint dataId, bool isPlayEffect = False) { }

	// RVA: 0x1D62DA0 Offset: 0x1D62EA1 VA: 0x1D62DA0
	private void FarmOutDelete() { }

	// RVA: 0x1D645D0 Offset: 0x1D646D1 VA: 0x1D645D0
	private void Update() { }

	// RVA: 0x1D647E0 Offset: 0x1D648E1 VA: 0x1D647E0
	private void OnDayCarry(int days) { }

	// RVA: 0x1D64930 Offset: 0x1D64A31 VA: 0x1D64930
	public void .ctor() { }
}


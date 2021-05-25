public class UIModelLoader : MonoBehaviour // TypeDefIndex: 8940
{
	// Fields
	[SerializeField] // RVA: 0x174D20 Offset: 0x174E21 VA: 0x174D20
	private Transform[] PointObjects; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x174D30 Offset: 0x174E31 VA: 0x174D30
	private UIModelLoader.POINT <NowPoint>k__BackingField; // 0x20
	private ActorID actorId; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x174D40 Offset: 0x174E41 VA: 0x174D40
	private bool <IsActive>k__BackingField; // 0x28
	private MonsterDataID usingMonsterDataId; // 0x2C
	private GameObject MonsterObject; // 0x30
	private ModelScaleDataTable ModelScaleDataTable; // 0x38

	// Properties
	public UIModelLoader.POINT NowPoint { get; set; }
	public bool IsActive { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A92B0 Offset: 0x1A93B1 VA: 0x1A92B0
	// RVA: 0x1EE2050 Offset: 0x1EE2151 VA: 0x1EE2050
	public UIModelLoader.POINT get_NowPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A92C0 Offset: 0x1A93C1 VA: 0x1A92C0
	// RVA: 0x1EE2060 Offset: 0x1EE2161 VA: 0x1EE2060
	private void set_NowPoint(UIModelLoader.POINT value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A92D0 Offset: 0x1A93D1 VA: 0x1A92D0
	// RVA: 0x1EE2070 Offset: 0x1EE2171 VA: 0x1EE2070
	public bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A92E0 Offset: 0x1A93E1 VA: 0x1A92E0
	// RVA: 0x1EE2080 Offset: 0x1EE2181 VA: 0x1EE2080
	private void set_IsActive(bool value) { }

	// RVA: 0x1EE2090 Offset: 0x1EE2191 VA: 0x1EE2090
	public void ChangePoint(UIModelLoader.POINT nextPoint, ActorID _actorID = -1) { }

	// RVA: 0x1EE2430 Offset: 0x1EE2531 VA: 0x1EE2430
	public void Open(ActorID actor_id, bool isViewer = False) { }

	// RVA: 0x1EE2640 Offset: 0x1EE2741 VA: 0x1EE2640
	private void DoOpenMonster(MonsterDataID id, GameObject _MonsterObject) { }

	// RVA: 0x1EE24B0 Offset: 0x1EE25B1 VA: 0x1EE24B0
	private void EndMonster() { }

	// RVA: 0x1EE2880 Offset: 0x1EE2981 VA: 0x1EE2880
	public void Open(MonsterDataID monsterDataID, bool isViewer = False) { }

	// RVA: 0x1EE2990 Offset: 0x1EE2A91 VA: 0x1EE2990
	public void Close() { }

	// RVA: 0x1EE29D0 Offset: 0x1EE2AD1 VA: 0x1EE29D0
	private void InitActorCache() { }

	// RVA: 0x1EE29E0 Offset: 0x1EE2AE1 VA: 0x1EE29E0
	private void SetupActor() { }

	// RVA: 0x1EE29F0 Offset: 0x1EE2AF1 VA: 0x1EE29F0
	private void TakeoverActor(Actor actor) { }

	// RVA: 0x1EE2590 Offset: 0x1EE2691 VA: 0x1EE2590
	private void ReturnActor() { }

	// RVA: 0x1EE2B50 Offset: 0x1EE2C51 VA: 0x1EE2B50
	public void ResetEquip(EquipSlotType equipSlotType = 14) { }

	// RVA: 0x1EE2C80 Offset: 0x1EE2D81 VA: 0x1EE2C80
	private void Update() { }

	// RVA: 0x1EE2CD0 Offset: 0x1EE2DD1 VA: 0x1EE2CD0
	public void .ctor() { }
}


public class GimmickEffectWallController : GimmickBase // TypeDefIndex: 7572
{
	// Fields
	[SerializeField] // RVA: 0x167660 Offset: 0x167761 VA: 0x167660
	private GameObject[] WallObjects; // 0x20
	[SerializeField] // RVA: 0x167670 Offset: 0x167771 VA: 0x167670
	private GateController[] GateControllers; // 0x28
	[SerializeField] // RVA: 0x167680 Offset: 0x167781 VA: 0x167680
	private GameObject[] AppearGameObjects; // 0x30
	private List<GameObject> BattleTargetObject; // 0x38
	private List<ParticleSystem> ParticleList; // 0x40
	private List<Collider> ColliderList; // 0x48
	private List<NavMeshObstacle> NavMeshObstacleList; // 0x50
	private Collider AreaCollider; // 0x58
	private bool IsDoneBattle; // 0x60
	private bool IsAppearWall; // 0x61

	// Methods

	// RVA: 0x1E9F270 Offset: 0x1E9F371 VA: 0x1E9F270 Slot: 6
	protected override void Start() { }

	// RVA: 0x1E9F280 Offset: 0x1E9F381 VA: 0x1E9F280 Slot: 7
	public override void SetGimmickState(bool newState) { }

	// RVA: 0x1E9F660 Offset: 0x1E9F761 VA: 0x1E9F660 Slot: 9
	public override void Init() { }

	// RVA: 0x1E9FB60 Offset: 0x1E9FC61 VA: 0x1E9FB60
	private void GoBattle() { }

	// RVA: 0x1E9F300 Offset: 0x1E9F401 VA: 0x1E9F300
	private void DoneBattle() { }

	// RVA: 0x1EA0240 Offset: 0x1EA0341 VA: 0x1EA0240
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1EA0370 Offset: 0x1EA0471 VA: 0x1EA0370
	private void OnDeadEnemy(MonsterControllerBase enemyControllerBase) { }

	// RVA: 0x1EA0400 Offset: 0x1EA0501 VA: 0x1EA0400
	private void OnDestroyGate(GateController gateEnemy) { }

	// RVA: 0x1E9FFE0 Offset: 0x1EA00E1 VA: 0x1E9FFE0
	private bool TargetObjectCheck() { }

	// RVA: 0x1EA04A0 Offset: 0x1EA05A1 VA: 0x1EA04A0
	public void .ctor() { }
}


public class AracneController : BossMonsterContoroller // TypeDefIndex: 7786
{
	// Fields
	private const float ROT_X_MIN = 10;
	private const float ROT_X_MAX = 60;
	private const float JUMP_RANGE = 20;
	private int MaxVenomCounter; // 0x510
	private GameObject AracneFlatWebPrefab; // 0x518
	private Vector3 FlatWebScale; // 0x520
	public List<MonsterControllerBase> MonsterList; // 0x530
	public List<AracneFlatWeb> AracneFlatWebList; // 0x538
	private Transform RapidVenomPoint; // 0x540
	private Transform BulletPoint; // 0x548

	// Methods

	// RVA: 0x227CDE0 Offset: 0x227CEE1 VA: 0x227CDE0 Slot: 130
	protected override void OnSetup() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2C90 Offset: 0x1A2D91 VA: 0x1A2C90
	// RVA: 0x227CF80 Offset: 0x227D081 VA: 0x227CF80 Slot: 131
	protected override IEnumerator OnSetupAsync() { }

	// RVA: 0x227D030 Offset: 0x227D131 VA: 0x227D030 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x227D0F0 Offset: 0x227D1F1 VA: 0x227D0F0 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x227D330 Offset: 0x227D431 VA: 0x227D330 Slot: 127
	public override void DestroyProjectileList() { }

	// RVA: 0x227D620 Offset: 0x227D721 VA: 0x227D620 Slot: 40
	protected override void Update() { }

	// RVA: 0x227D6C0 Offset: 0x227D7C1 VA: 0x227D6C0
	private void UpdateBulletPointRotation() { }

	// RVA: 0x227D800 Offset: 0x227D901 VA: 0x227D800
	private float GetAngleX(Transform transform, float min, float max) { }

	// RVA: 0x227D9B0 Offset: 0x227DAB1 VA: 0x227D9B0
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x227DE50 Offset: 0x227DF51 VA: 0x227DE50
	private void CreateAracneFlatWeb(MonsterProjectileActionScriptsController projectileActionScriptsController) { }

	// RVA: 0x227E380 Offset: 0x227E481 VA: 0x227E380
	private void DestroyAracneFlatWebEvent(AracneFlatWeb aracneFlatWeb) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A2D00 Offset: 0x1A2E01 VA: 0x1A2D00
	// RVA: 0x227E420 Offset: 0x227E521 VA: 0x227E420
	private IEnumerator Spawn(int level, Vector3 offset) { }

	// RVA: 0x227E500 Offset: 0x227E601 VA: 0x227E500 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x227E980 Offset: 0x227EA81 VA: 0x227E980
	public void .ctor() { }
}


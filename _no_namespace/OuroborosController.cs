public class OuroborosController : BossMonsterContoroller // TypeDefIndex: 7956
{
	// Fields
	private const float GROUND_RANDOM_RANGE_MAX = 20;
	private const float GROUND_RANDOM_RANGE_MIN = 5;
	private const float GROUND_END_PLYAER_OFFSET_POS = 1;
	private const float TORNADO_RANDOM_RANGE_MAX = 30;
	private const float TORNADO_RANDOM_RANGE_MIN = 3;
	[SerializeField] // RVA: 0x169E30 Offset: 0x169F31 VA: 0x169E30
	private Transform[] WindCutterPoints; // 0x510
	private float Radius; // 0x518
	private float SweepPower; // 0x51C
	private GameObject TornadoTarget1; // 0x520
	private GameObject TornadoTarget2; // 0x528
	private GameObject TornadoTarget3; // 0x530
	private List<PartyBase> Parties; // 0x538
	private bool IsUnder; // 0x540
	private bool IsLeave; // 0x541
	private Tweener MoveTweener; // 0x548
	private Sequence MoveSequence; // 0x550

	// Methods

	// RVA: 0x21B8D80 Offset: 0x21B8E81 VA: 0x21B8D80 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x21B8ED0 Offset: 0x21B8FD1 VA: 0x21B8ED0 Slot: 155
	protected override bool CanReciveItem() { }

	// RVA: 0x21B8EF0 Offset: 0x21B8FF1 VA: 0x21B8EF0 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x21B8F50 Offset: 0x21B9051 VA: 0x21B8F50 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x21B90B0 Offset: 0x21B91B1 VA: 0x21B90B0
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x21B9150 Offset: 0x21B9251 VA: 0x21B9150
	private void SetTornadoTarget() { }

	// RVA: 0x21B9350 Offset: 0x21B9451 VA: 0x21B9350
	private void SetTornadoTarget(Transform transform) { }

	// RVA: 0x21B9470 Offset: 0x21B9571 VA: 0x21B9470
	private Vector3 GetRandomPos(Vector3 dir, float maxRange, float minRange = 0) { }

	// RVA: 0x21B95E0 Offset: 0x21B96E1 VA: 0x21B95E0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x21B9FF0 Offset: 0x21BA0F1 VA: 0x21B9FF0 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x21BA410 Offset: 0x21BA511 VA: 0x21BA410
	public void .ctor() { }
}


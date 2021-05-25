public class AriesController : BossMonsterContoroller // TypeDefIndex: 7798
{
	// Fields
	private const float SPARK_SCALE = 4.5;
	private Transform BulletPointTransform; // 0x510
	private int HairCounter; // 0x518
	private int MaxHair; // 0x51C
	private Transform SparkPointTransform; // 0x520
	private Vector3 SparkPointLocalPos; // 0x528
	private bool IsSlidingSleep1; // 0x534
	private bool IsSlidingSleep2; // 0x535
	private int BouncingCount; // 0x538
	private int MaxBouncing; // 0x53C
	private static readonly Vector3 ATTACK_RANGE_EFFECT_SCALE; // 0x0
	private static readonly Vector3 JUMP_ATTACK_EFFECT_SCALE; // 0xC
	private Vector3 JumpPosition; // 0x540
	private ParticleSystem JumpPointEffect; // 0x550
	private ParticleSystem JumpAttackEffect; // 0x558

	// Properties
	private bool IsLessMaxHair { get; }

	// Methods

	// RVA: 0x2286190 Offset: 0x2286291 VA: 0x2286190
	private bool get_IsLessMaxHair() { }

	// RVA: 0x22861B0 Offset: 0x22862B1 VA: 0x22861B0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x22862F0 Offset: 0x22863F1 VA: 0x22862F0 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x2286430 Offset: 0x2286531 VA: 0x2286430 Slot: 12
	protected override void Start() { }

	// RVA: 0x2286520 Offset: 0x2286621 VA: 0x2286520 Slot: 40
	protected override void Update() { }

	// RVA: 0x22866D0 Offset: 0x22867D1 VA: 0x22866D0
	private void CreateProjectile(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x2286550 Offset: 0x2286651 VA: 0x2286550
	private void UpdateSparkPos() { }

	// RVA: 0x22868C0 Offset: 0x22869C1 VA: 0x22868C0
	private void CheckRushSlidingSleep1(string next, int sleepPercent) { }

	// RVA: 0x2286940 Offset: 0x2286A41 VA: 0x2286940
	private void CheckRushSlidingSleep2(string next) { }

	// RVA: 0x22869C0 Offset: 0x2286AC1 VA: 0x22869C0 Slot: 65
	public override void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x2286B50 Offset: 0x2286C51 VA: 0x2286B50 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x2286F30 Offset: 0x2287031 VA: 0x2286F30
	private void SetJumpPoint() { }

	// RVA: 0x2287080 Offset: 0x2287181 VA: 0x2287080
	private void EraseJumpPoint() { }

	// RVA: 0x22870B0 Offset: 0x22871B1 VA: 0x22870B0
	private void SetJumpAttackEffect() { }

	// RVA: 0x2287130 Offset: 0x2287231 VA: 0x2287130
	public void .ctor() { }

	// RVA: 0x2287140 Offset: 0x2287241 VA: 0x2287140
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2DF0 Offset: 0x1A2EF1 VA: 0x1A2DF0
	// RVA: 0x2287200 Offset: 0x2287301 VA: 0x2287200
	private void <Start>b__19_0(ParticleSystem particle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2E00 Offset: 0x1A2F01 VA: 0x1A2E00
	// RVA: 0x22873C0 Offset: 0x22874C1 VA: 0x22873C0
	private void <Start>b__19_1(ParticleSystem particle) { }
}

